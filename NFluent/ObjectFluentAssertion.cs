﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ObjectFluentAssertion.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN, Marc-Antoine LATOUR
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    /// <summary>
    /// Provides assertion methods to be executed on an object instance.
    /// </summary>
    public class ObjectFluentAssertion : ObjectBaseFluentAssertion<IObjectFluentAssertion>, IObjectFluentAssertion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFluentAssertion" /> class.
        /// </summary>
        /// <param name="sut">The System Under Test.</param>
        public ObjectFluentAssertion(object sut)
            : base(sut)
        {
        }
    }
}