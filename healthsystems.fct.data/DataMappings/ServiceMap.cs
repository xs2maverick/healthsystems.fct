﻿using FluentNHibernate.Mapping;

namespace healthsystems.fct.data
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
        }
    }
}
