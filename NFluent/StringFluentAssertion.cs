// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="StringFluentAssertion.cs" company="">
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
    /// Provides assertion methods to be executed on a string instance.
    /// </summary>
    internal class StringFluentAssertion : StringBaseFluentAssertion<IStringFluentAssertion>, IStringFluentAssertion
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFluentAssertion"/> class.
        /// </summary>
        /// <param name="value">
        /// The String Under Test.
        /// </param>
        public StringFluentAssertion(string value)
            : base(value)
        {
        }

        #endregion
    }
}