/* IBudget.cs
 * This interface forces teams that implement
 * it to include a method indicating how they
 * are budgetted.
 */
using System;

namespace TeamBaseClass
{
    interface IBudget
    {
        // abstract method
        string ShowHowBudgeted();
    }
}
