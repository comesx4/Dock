﻿
using Dock.Model.Core;

namespace Dock.Model.Controls
{
    /// <summary>
    /// Document dock contract.
    /// </summary>
    public interface IDocumentDock : IDock
    {
        /// <summary>
        /// Gets or sets if document dock can create new documents.
        /// </summary>
        bool CanCreateDocument { get; set; }
    }
}
