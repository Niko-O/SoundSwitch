﻿/********************************************************************
* Copyright (C) 2015-2017 Antoine Aflalo
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
********************************************************************/

using System.Collections.Generic;
using NAudio.CoreAudioApi;

namespace SoundSwitch.Model
{
    public interface IAudioDeviceLister
    {
        /// <summary>
        ///     Get the playback device in the set state
        /// </summary>
        /// <returns></returns>
        MMDeviceCollection GetPlaybackDevices();

        /// <summary>
        ///     Get the recording device in the set state
        /// </summary>
        /// <returns></returns>
        MMDeviceCollection GetRecordingDevices();
    }
}