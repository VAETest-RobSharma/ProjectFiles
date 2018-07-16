using System;

namespace VAEProgramEx.LineProcessor
{
    /// <summary>
    /// Class BigramTuple.
    /// This is a class to hold each element and provide processing for those elements
    /// </summary>
    /// <typeparam name="T1">The type of the t1.</typeparam>
    /// <typeparam name="T2">The type of the t2.</typeparam>
    /// <typeparam name="T3">The type of the t3.</typeparam>
    /// <seealso cref="object" />
    public class BigramTuple<T1, T2, T3> : IEquatable<object>
        {
        public T1 Word1 { get; set; }

        public T2 Word2 { get; set; }

        public T3 BigramCount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigramTuple{T1,T2,T3}"/> class.
        /// </summary>
        /// <param name="word1">The word1.</param>
        /// <param name="word2">The word2.</param>
        /// <param name="bigramCount">The bigram count.</param>
        public BigramTuple(T1 word1, T2 word2, T3 bigramCount)
            {
                this.Word1 = word1;
                this.Word2 = word2;
                this.BigramCount = bigramCount;
            }

        public BigramTuple()
        {
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
            {
                if (obj == null || (obj as BigramTuple<T1, T2, T3>) == null) //if the object is null or the cast fails
                    return false;
                else
                {
                    BigramTuple<T1, T2, T3> bigramTuple = (BigramTuple<T1, T2, T3>)obj;
                    return (Word1.ToString().ToLower().Equals(bigramTuple.Word1.ToString().ToLower()) && Word2.ToString().ToLower().Equals(bigramTuple.Word2.ToString().ToLower())) || 
                        (Word1.ToString().ToLower().Equals(bigramTuple.Word1.ToString().ToLower()) && string.IsNullOrEmpty(bigramTuple.Word2.ToString()));
                }
            }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
             return Word1.GetHashCode() ^ Word2.GetHashCode() ^ BigramCount.GetHashCode();
        }

      
    }
   
}
