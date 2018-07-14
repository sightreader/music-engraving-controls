/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using Manufaktura.Model.MVVM;
using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.UniversalApps.Common
{
    public class ListContentControl : ContentControl
    {
         public event EventHandler ContentChangeAnimationCompleted;
        /*private DoubleAnimation _fadeInAnimation = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromMilliseconds(250)), FillBehavior.Stop);
        private DoubleAnimation _fadeOutAnimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromMilliseconds(250)), FillBehavior.Stop);
        private UIElement _pendingContent;*/

        public bool IsAnimationEnabled
        {
            get { return (bool)GetValue(IsAnimationEnabledProperty); }
            set { SetValue(IsAnimationEnabledProperty, value); }
        }

        public UIElement InitialView
        {
            get { return (UIElement)GetValue(InitialViewProperty); }
            set { SetValue(InitialViewProperty, value); }
        }

        public UIElement ProgressView
        {
            get { return (UIElement)GetValue(ProgressViewProperty); }
            set { SetValue(ProgressViewProperty, value); }
        }

        public UIElement ResultsView
        {
            get { return (UIElement)GetValue(ResultsViewProperty); }
            set { SetValue(ResultsViewProperty, value); }
        }

        public UIElement NoResultsView
        {
            get { return (UIElement)GetValue(NoResultsViewProperty); }
            set { SetValue(NoResultsViewProperty, value); }
        }

        public UIElement ErrorView
        {
            get { return (UIElement)GetValue(ErrorViewProperty); }
            set { SetValue(ErrorViewProperty, value); }
        }

        public ListViewModelStates State
        {
            get { return (ListViewModelStates)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static readonly DependencyProperty InitialViewProperty =
            DependencyProperty.Register("InitialView", typeof(UIElement), typeof(ListContentControl), new PropertyMetadata(null, InitialViewChangedCallback));

        private static void InitialViewChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ListContentControl control = dependencyObject as ListContentControl;
            control.Content = control.InitialView;
        }

        public static readonly DependencyProperty ProgressViewProperty =
            DependencyProperty.Register("ProgressView", typeof(UIElement), typeof(ListContentControl), new PropertyMetadata(null));

        public static readonly DependencyProperty ResultsViewProperty =
            DependencyProperty.Register("ResultsView", typeof(UIElement), typeof(ListContentControl), new PropertyMetadata(null));

        public static readonly DependencyProperty NoResultsViewProperty =
            DependencyProperty.Register("NoResultsView", typeof(UIElement), typeof(ListContentControl), new PropertyMetadata(null));

        public static readonly DependencyProperty ErrorViewProperty =
            DependencyProperty.Register("ErrorView", typeof(UIElement), typeof(ListContentControl), new PropertyMetadata(null));

        public static readonly DependencyProperty IsAnimationEnabledProperty =
            DependencyProperty.Register("IsAnimationEnabled", typeof(bool), typeof(ListContentControl), new PropertyMetadata(true));

        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(ListViewModelStates), typeof(ListContentControl), new PropertyMetadata(ListViewModelStates.Idle, ChooseProperContent));

        public ListContentControl()
        {
            //_fadeInAnimation.Completed += FadeInAnimation_Completed;
            //_fadeOutAnimation.Completed += _fadeOutAnimation_Completed;
        }

        private static void ChooseProperContent(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ListContentControl control = (ListContentControl)obj;
            switch ((ListViewModelStates)args.NewValue)
            {
                case ListViewModelStates.Results:
                    control.Content = control.ResultsView;
                    break;
                case ListViewModelStates.Idle:
                    //if (IsAnimationEnabled) ChangeContentUsingAnimation(InitialView);
                    //else
                    control.Content = control.InitialView;
                    break;
                case ListViewModelStates.NoResults:
                    //if (IsAnimationEnabled) ChangeContentUsingAnimation(NoResultsView);
                    //else
                    control.Content = control.NoResultsView;
                    break;
                case ListViewModelStates.Progress:
                    //if (IsAnimationEnabled) ChangeContentUsingAnimation(ProgressView);
                    //else 
                    control.Content = control.ProgressView;
                    break;
                case ListViewModelStates.Error:
                    //if (IsAnimationEnabled) ChangeContentUsingAnimation(ErrorView);
                    //else 
                    control.Content = control.ErrorView;
                    break;
                default:
                    throw new NotImplementedException("Stan " + (ListViewModelStates)args.NewValue + " nie jest obsługiwany przez kontrolkę.");
            }
        }

        /*private void ChangeContentUsingAnimation(UIElement newContent)
        {
            _pendingContent = newContent;
            IsHitTestVisible = false;   //Zablokuj kontrolkę, żeby nie dało się klikać podczas zmiany kontentu
            BeginAnimation(OpacityProperty, _fadeInAnimation);
        }

        void FadeInAnimation_Completed(object sender, EventArgs e)
        {
            Content = _pendingContent;
            BeginAnimation(OpacityProperty, null);
            BeginAnimation(OpacityProperty, _fadeOutAnimation);
        }

        void _fadeOutAnimation_Completed(object sender, EventArgs e)
        {
            BeginAnimation(OpacityProperty, null);
            IsHitTestVisible = true;    //Odblokuj kontrolkę.
            OnContentChangeAnimationCompleted();
        }*/

        private void OnContentChangeAnimationCompleted()
        {
            if (ContentChangeAnimationCompleted != null) ContentChangeAnimationCompleted(this, new EventArgs());
        }
    }
}
