﻿//-----------------------------------------------------------------------
// <copyright file="ISimpleLogger.cs">
//     Copyright (c) 2014-2020 Adam Craven. All rights reserved.
// </copyright>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

namespace ChannelAdam.Logging.Abstractions
{
    /// <summary>
    /// Interface for a simple logger.
    /// </summary>
    public interface ISimpleLogger
    {
        /// <summary>
        /// Logs an empty line.
        /// </summary>
        void Log();

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Log(string message);

        /// <summary>
        /// Logs the specified message format.
        /// </summary>
        /// <param name="messageFormat">The message format.</param>
        /// <param name="arguments">The argument list.</param>
        void Log(string messageFormat, params object[] arguments);
    }
}
