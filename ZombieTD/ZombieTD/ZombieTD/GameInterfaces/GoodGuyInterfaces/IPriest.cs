﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieTD
{
    public interface IPriest
    {
        void ThrowHolyWater(IMediator mediator, ICharacter character, ICharacter target);
    }
}
