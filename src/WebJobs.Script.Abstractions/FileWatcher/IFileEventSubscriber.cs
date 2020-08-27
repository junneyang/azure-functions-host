// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.Azure.WebJobs.Script.Abstractions.FileWatcher
{
    public interface IFileEventSubscriber
    {
        /// <summary>
        /// Returns a decision to take when a file event occured
        /// </summary>
        /// <param name="fileEvent">The data for the file or directory that the event occured for.</param>
        /// <returns><see cref="FileEventResponse"/> indicating the action to take in response.</returns>
        FileEventResponse OnFileEvent(FileSystemEventArgs fileEvent);
    }
}
