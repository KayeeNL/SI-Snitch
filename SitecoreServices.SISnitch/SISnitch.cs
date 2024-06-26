﻿using System.Security.Claims;
using Sitecore.Abstractions;
using Sitecore.Diagnostics;
using Sitecore.Owin.Authentication.Services;

namespace SitecoreServices.SISnitch
{
    public class Snitch : Transformation
    {
        public Snitch(BaseLog log)
        {
            Assert.ArgumentNotNull(log, nameof(log));
            Log = log;
        }

        protected BaseLog Log { get; }

        public override void Transform(ClaimsIdentity identity, TransformationContext context)
        {
            Assert.ArgumentNotNull(identity, nameof(identity));
            Assert.ArgumentNotNull(context, nameof(context));

            foreach (var c in identity.Claims) Log.Info($"oO SI Snitch Oo -- Claim: {c.Type} || Value: {c.Value}", this);
        }
    }
}