﻿/*
 * Copyright (c) 2015 by Windward Studios, Inc. All rights reserved.
 *
 * This software is the confidential and proprietary information of
 * Windward Studios ("Confidential Information").  You shall not
 * disclose such Confidential Information and shall use it only in
 * accordance with the terms of the license agreement you entered into
 * with Windward Studios, Inc.
 */

using System;
using System.IO;

namespace RESTfulEngine.CSharpClient
{
    /// <summary>
    /// Generates a report in the CSV format.
    /// </summary>
    public class ReportCsv : Report
    {
        public ReportCsv(Uri uri, Stream template, Stream report)
            : base(uri, template, report)
        {

        }

        public ReportCsv(Uri uri, Stream template)
            : base(uri, template)
        {
        }

        protected override string OutputFormat
        {
            get
            {
                return "csv";
            }
        }
    }
}
