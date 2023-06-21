﻿namespace PhiJudge.Server.Models
{
    public enum PointStatus
    {
        Accepted = 0,
        WrongAnswer = 1,
        RuntimeError = 2,
        TimeLimitExceeded = 3,
        MemoryLimitExceeded = 4,
        OutputLimitExceeded = 5,
        PresentationError = 6,
        InternalError = 7,
        Judging = 8,
        Pending = 9
    }
}
