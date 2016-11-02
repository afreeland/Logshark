﻿using System;
using System.Collections.Generic;

namespace LogParsers
{
    /// <summary>
    /// Contains the mapping context between files within the "licensing" directory in the logs and their associated parsers.
    /// </summary>
    internal sealed class LicensingParserBuilder : BaseParserBuilder, IParserBuilder
    {
        private static readonly IDictionary<string, Type> fileMap =
            new Dictionary<string, Type>
            {
                { @"^.*_lic.*log.*", typeof(LicensingParser) }
            };

        protected override IDictionary<string, Type> FileMap
        {
            get { return fileMap; }
        }
    }
}