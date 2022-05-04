namespace <CrtImplementationDetails>
{
    using System;
    using System.Collections;
    using System.Runtime.ConstrainedExecution;
    using System.Security;

    internal class ModuleUninitializer : Stack
    {
        private static object @lock;
        internal static ModuleUninitializer _ModuleUninitializer;

        [SecurityCritical]
        static ModuleUninitializer();
        [SecuritySafeCritical]
        private ModuleUninitializer();
        [SecuritySafeCritical]
        internal void AddHandler(EventHandler handler);
        [PrePrepareMethod, SecurityCritical]
        private void SingletonDomainUnload(object source, EventArgs arguments);
    }
}

