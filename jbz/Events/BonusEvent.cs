﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Events;

namespace Jbz.Events
{
    public class BonusEvent : CompositePresentationEvent<KeyValuePair<int, int>>
    {
    }
}
