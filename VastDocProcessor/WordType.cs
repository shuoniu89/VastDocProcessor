﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastDocProcessor
{
    enum WordType
    {
        DEFAULT,
        PUNCTUATION,
        STOPWORD,
        IRREGULAR,
        REGULAR,

        LINEBREAK,

        DATE,
        LOCACTION,
        MONEY,
        ORGANIZATION,
        PERSON,
        TIME
    }
}
