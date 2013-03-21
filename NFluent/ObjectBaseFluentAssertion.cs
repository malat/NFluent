// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ObjectBaseFluentAssertion.cs" company="">
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
    using NFluent.Helpers;

    /// <summary>
    /// The base class for object base assertion.
    /// </summary>
    /// <typeparam name="T">
    /// The real T.
    /// </typeparam>
    public class ObjectBaseFluentAssertion<T> : IObjectFluentAssertionTrait<T>
        where T : class, IFluentAssertion
    {
        private readonly object sut;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectBaseFluentAssertion{T}"/> class. 
        /// </summary>
        /// <param name="sut">
        /// The System Under Test.
        /// </param>
        public ObjectBaseFluentAssertion(object sut)
        {
            this.sut = sut;
        }

        /// <summary>
        /// Checks that the actual value is equal to another expected value.
        /// </summary>
        /// <returns>A chainable assertion.</returns>
        /// <param name="expected">The expected value.</param>
        /// <exception cref="FluentAssertionException">The actual value is not equal to the expected value.</exception>
        public virtual IChainableFluentAssertion<T> IsEqualTo(object expected)
        {
            EqualityHelper.IsEqualTo(this.sut, expected);
            return new ChainableFluentAssertion<T>(this as T);
        }

        /// <summary>
        /// Checks that the actual value is not equal to another expected value.
        /// </summary>
        /// <returns>A chainable assertion.</returns>
        /// <param name="expected">The expected value.</param>
        /// <exception cref="FluentAssertionException">The actual value is equal to the expected value.</exception>
        public virtual IChainableFluentAssertion<T> IsNotEqualTo(object expected)
        {
            EqualityHelper.IsNotEqualTo(this.sut, expected);
            return new ChainableFluentAssertion<T>(this as T);
        }

        /// <summary>
        /// Checks that the actual instance is an instance of the given type.
        /// </summary>
        /// <typeparam name="TOf">
        /// The testing type.
        /// </typeparam>
        /// <returns>
        /// A chainable fluent assertion.
        /// </returns>
        /// <exception cref="FluentAssertionException">
        /// The actual instance is not of the provided type.
        /// </exception>
        public virtual IChainableFluentAssertion<T> IsInstanceOf<TOf>()
        {
            IsInstanceHelper.IsInstanceOf(this.sut, typeof(TOf));
            return new ChainableFluentAssertion<T>(this as T);
        }

        /// <summary>
        /// Checks that the actual instance is not an instance of the given type.
        /// </summary>
        /// <typeparam name="TOf">
        /// The testing type.
        /// </typeparam>
        /// <returns>
        /// A chainable fluent assertion.
        /// </returns>
        /// <exception cref="FluentAssertionException">
        /// The actual instance is of the provided type.
        /// </exception>
        public virtual IChainableFluentAssertion<T> IsNotInstanceOf<TOf>()
        {
            IsInstanceHelper.IsNotInstanceOf(this.sut, typeof(TOf));
            return new ChainableFluentAssertion<T>(this as T);
        }
    }
}