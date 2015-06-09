// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Properties of the activity.
    /// </summary>
    public partial class ActivityProperties : ResourceCommonPropertiesBase
    {
        private string _definition;
        
        /// <summary>
        /// Optional. Gets or sets the user name of the activity.
        /// </summary>
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }
        
        private IList<ActivityOutputType> _outputTypes;
        
        /// <summary>
        /// Optional. Gets or sets the output types of the activity.
        /// </summary>
        public IList<ActivityOutputType> OutputTypes
        {
            get { return this._outputTypes; }
            set { this._outputTypes = value; }
        }
        
        private IList<ActivityParameterSet> _parameterSets;
        
        /// <summary>
        /// Optional. Gets or sets the parameter sets of the activity.
        /// </summary>
        public IList<ActivityParameterSet> ParameterSets
        {
            get { return this._parameterSets; }
            set { this._parameterSets = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ActivityProperties class.
        /// </summary>
        public ActivityProperties()
        {
            this.OutputTypes = new LazyList<ActivityOutputType>();
            this.ParameterSets = new LazyList<ActivityParameterSet>();
        }
    }
}