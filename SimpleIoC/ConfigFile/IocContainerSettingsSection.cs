﻿using System;
using System.Configuration;

namespace SimpleIoC.ConfigFile
{
    public sealed class IocContainerSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("registeredObjects", IsDefaultCollection = true, IsRequired = true)]
        public RegisteredObjectElementCollection RegisteredObjects
        {
            get
            {
                return (RegisteredObjectElementCollection)this["registeredObjects"];
            }
            set
            {
                this["registeredObjects"] = value;
            }
        }
    }
}
