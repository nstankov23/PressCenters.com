﻿namespace PressCenters.Worker.Common
{
    using System.Reflection;

    public interface ITasksAssemblyProvider
    {
        Assembly GetAssembly();
    }
}
