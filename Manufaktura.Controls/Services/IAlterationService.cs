using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Service used for storing temporary information about alterations.
    /// </summary>
    public interface IAlterationService
    {
        /// <summary>
        /// Resets alteration data
        /// </summary>
        void Reset();

        /// <summary>
        /// Gets alteration for a step.
        /// </summary>
        /// <param name="step">Step</param>
        /// <returns>Alteration for given step</returns>
        int Get(Step step);

        /// <summary>
        /// Sets alteraion for a given step.
        /// </summary>
        /// <param name="step">Step</param>
        /// <param name="value">Alteration value (positive: sharps, negative: flats)</param>
        void Set(Step step, int value);
    }
}
