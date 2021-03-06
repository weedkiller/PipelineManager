﻿using System;
using Pipelines;

namespace UnitTests
{
    public class FailingStep : BaseStep
    {
        public FailingStep(UniqueStepId stepId)
            : base(stepId)
        {
        }

        public override StepExecutionResult Resume(IUnitOfWork unitOfWork, DataContainer optionalData, TimeSpan retryTime)
        {
            return StepExecutionResult.Fail;
        }
    }
}