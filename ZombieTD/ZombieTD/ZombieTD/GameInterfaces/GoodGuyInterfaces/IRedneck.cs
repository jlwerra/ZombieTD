﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieTD
{
    public interface IRedneck
    {
        void CutOffArm(IMediator mediator, ICharacter character, ICharacter target);
    }
}
