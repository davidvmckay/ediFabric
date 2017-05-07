﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;
using EdiFabric.Annotations.Model;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Framework.Parsers
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            BuildChildren(instance, true);
        }

        public ComplexDataElement(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren(null, true);
        }

        public override void Parse(string value, Separators separators)
        {
            IsParsed = true;
            var index = 0;
            foreach (var currentToParse in value.GetComponentDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

                var currentElement = Children.ElementAt(index);
                if (currentElement.IsParsed)
                {
                    currentElement = currentElement.InsertRepetition();
                    index++;
                }
                currentElement.Parse(currentToParse, separators);
                index++;
            }
        }

        public override ParseNode InsertRepetition()
        {
            return new ComplexDataElement(this);
        }
    }
}
