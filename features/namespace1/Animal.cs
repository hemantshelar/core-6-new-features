using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_6_new_features.features.namespace1;
public class AnimalNS1
{
    public AnimalNS1()
    {
        
    }
    private int _age;
    public int Age
    {
        get => _age;
        init => _age = value;
    }

}