﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieTD
{
    public interface ISheriff
    {
        void FireGun(IMediator mediatror, ICharacter character, ICharacter target);
    }
}
