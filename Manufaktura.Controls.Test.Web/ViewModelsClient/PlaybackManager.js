﻿var PlaybackManager = function () {
    var self = this;
    this.isPlaying = false;
    this.stopToken = 0;

    this.play = function (melodyId) {
        var svg = $("#melody-" + melodyId + " svg");
        if (self.currentMelodyId) {
            $("#btnPlay-" + self.currentMelodyId).show();
            $("#btnStop-" + self.currentMelodyId).hide();
        }
        self.currentMelodyId = melodyId;
        $("#btnPlay-" + melodyId).hide();
        $("#btnStop-" + melodyId).show();

        self.isPlaying = true;
        self.stopToken++;
        var currentStopToken = self.stopToken;
        var overalTime = 0;

        function colorBlack(elements) {
            for (var i in elements) {
                var e = elements[i];
                if (e.tagName === "line" || e.tagName === "path") e.style.stroke = "#000";
                else e.style.fill = "#000";
            }
        }
        function colorRed(elements) {
            for (var i in elements) {
                var e = elements[i];
                if (e.tagName === "line" || e.tagName === "path") e.style.stroke = "#c34853";
                else e.style.fill = "#c34853";
            }
        }

        var notes = [];


        svg.children().each(function (i, e) {

            var delayTime = $(e).attr("data-playback-start");

            if (delayTime == null) return;
            delayTime = parseInt(delayTime);

            var pitchUnparsed = $(e).attr("data-midi-pitch");
            var pitch = pitchUnparsed ? parseInt(pitchUnparsed) : null;
            var durationUnparsed = $(e).attr("data-playback-duration");
            if (durationUnparsed == null) return;
            var duration = parseInt(durationUnparsed);

            if (notes.length > 0 && notes[notes.length - 1].id === $(e).attr("id")) {
                notes[notes.length - 1].elements.push(e);
            }
            else {
                var note = { delayTime: delayTime, pitch: pitch, duration: duration, elements: [], id: $(e).attr("id") };
                note.elements.push(e);
                notes.push(note);
            }
            overalTime = delayTime + duration;
        });

        for (var i in notes) {
            var noteInfo = notes[i];

            setTimeout(function (note) {
                return function () {
                    if (self.stopToken !== currentStopToken) {
                        colorBlack(note.elements);
                        return;
                    }

                    if (note.pitch != null) {
                        MIDI.noteOn(0, note.pitch, 127, 0);
                        MIDI.noteOff(0, note.pitch, note.duration * 0.001);
                    }
                    colorRed(note.elements);
                };
            }(noteInfo), noteInfo.delayTime);

            setTimeout(function (note) {
                return function () {
                    colorBlack(note.elements);
                };
            }(noteInfo), noteInfo.delayTime + noteInfo.duration);
        }

        setTimeout(function () {
            if (self.stopToken !== currentStopToken) return;
            self.isPlaying = false;
        }, overalTime);
    }

    this.stop = function () {
        console.info('Stop');
        if (self.currentMelodyId) {
            $("#btnPlay-" + this.currentMelodyId).show();
            $("#btnStop-" + this.currentMelodyId).hide();
        }
        self.stopToken++;
        self.isPlaying = false;
    }
}
window.player = new PlaybackManager();



