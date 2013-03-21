// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="StringBaseFluentAssertion.cs" company="">
// //   Copyright 2013 Marc-Antoine LATOUR
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
    using System.Collections.Generic;

    internal class StringBaseFluentAssertion<T> : ObjectBaseFluentAssertion<T>, IStringFluentAssertionTrait<T>
        where T : class, IFluentAssertion
    {
        private readonly string sut;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringBaseFluentAssertion{T}"/> class. 
        /// </summary>
        /// <param name="value">
        /// The String Under Test.
        /// </param>
        public StringBaseFluentAssertion(string value) 
            : base(value)
        {
            this.sut = value;
        }

        /// <summary>
        /// Checks that the string contains the given expected values, in any order.
        /// </summary>
        /// <param name="values">
        /// The expected values to be found.
        /// </param>
        /// <returns>
        /// A chainable assertion.
        /// </returns>
        /// <exception cref="FluentAssertionException">
        /// The string does not contains all the given strings in any order.
        /// </exception>
        public IChainableFluentAssertion<T> Contains(params string[] values)
        {
            var notFound = new List<string>();
            foreach (string value in values)
            {
                if (!this.sut.Contains(value))
                {
                    notFound.Add(value);
                }
            }

            if (notFound.Count > 0)
            {
                throw new FluentAssertionException(string.Format(@"The string [""{0}""] does not contain the expected value(s): [{1}].", this.sut, notFound.ToEnumeratedString()));
            }
            
            return new ChainableFluentAssertion<T>(this as T);
        }

        /// <summary>
        /// Checks that the string starts with the given expected prefix.
        /// </summary>
        /// <param name="expectedPrefix">
        /// The expected prefix.
        /// </param>
        /// <returns>
        /// A chainable assertion.
        /// </returns>
        /// <exception cref="FluentAssertionException">
        /// The string does not start with the expected prefix.
        /// </exception>
        public IChainableFluentAssertion<T> StartsWith(string expectedPrefix)
        {
            if (!this.sut.StartsWith(expectedPrefix))
            {
                throw new FluentAssertionException(string.Format(@"The string [""{0}""] does not start with [""{1}""].", this.sut, expectedPrefix));
            }

            return new ChainableFluentAssertion<T>(this as T);
        }
    }
}