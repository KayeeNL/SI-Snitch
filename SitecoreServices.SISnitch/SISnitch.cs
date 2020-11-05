using System;
using System.Security.Claims;
using Sitecore.Owin.Authentication.Services;
using Sitecore.Abstractions;
using Sitecore.Diagnostics;

namespace SitecoreServices.SISnitch
{
    public class Snitch : Transformation
    {

        public Snitch(BaseLog log)
        {
            Assert.ArgumentNotNull(log, "log");
            Log = log;
        }

        public override void Transform(ClaimsIdentity identity, TransformationContext context)
        {
            foreach (Claim c in identity.Claims)
            {
                Log.Info(String.Format("oO SI Snitch Oo -- Claim: {0} || Value: {1}", c.Type, c.Value), this);
            }
        }

        protected BaseLog Log { get; }
    }
}
