﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSpec.Interpreter.Indexer;
using NSpec.Extensions;

namespace SampleSpecs.Demo
{
    public class SomeSharedSpec : spec
    {
    }

    public class when_inherting_from_some_shared_spec : SomeSharedSpec
    {
        public void should_still_run_tests()
        {
            specify(() => "Test".should_be("Test"));
        }
    }
}
