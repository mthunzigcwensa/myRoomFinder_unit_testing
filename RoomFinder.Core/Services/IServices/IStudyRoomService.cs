﻿using RoomFinder.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomFinder.Core.Services.IServices
{
    public interface IStudyRoomService
    {
        IEnumerable<StudyRoom> GetAll();


    }
}
