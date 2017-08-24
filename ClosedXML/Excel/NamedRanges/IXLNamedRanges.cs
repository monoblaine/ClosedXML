#nullable disable

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
    public interface IXLNamedRanges: IEnumerable<IXLNamedRange>
    {
        /// <summary>
        /// Gets the specified named range.
        /// </summary>
        /// <param name="rangeName">Name of the range.</param>
        IXLNamedRange NamedRange(String rangeName);
        
        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the range to add.</param>
        /// <param name="rangeAddress">The range address to add.</param>
        IXLNamedRange Add(String rangeName, String rangeAddress);

        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the range to add.</param>
        /// <param name="range">The range to add.</param>
        IXLNamedRange Add(String rangeName, IXLRange range);

        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the range to add.</param>
        /// <param name="ranges">The ranges to add.</param>
        IXLNamedRange Add(String rangeName, IXLRanges ranges);

        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the ranges to add.</param>
        /// <param name="rangeAddress">The range address to add.</param>
        /// <param name="comment">The comment for the new named range.</param>
        IXLNamedRange Add(String rangeName, String rangeAddress, String comment);

        /// <summary>
        /// Adds the specified range name.
        /// </summary>
        /// <param name="rangeName">Name of the range.</param>
        /// <param name="rangeAddress">The range address.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="validateName">if set to <c>true</c> validates the name.</param>
        /// <param name="validateRangeAddress">if set to <c>true</c> range address will be checked for validity.</param>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentException">
        /// For named ranges in the workbook scope, specify the sheet name in the reference.
        /// </exception>
        IXLNamedRange Add(String rangeName, String rangeAddress, String comment, Boolean validateName, Boolean validateRangeAddress);

        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the ranges to add.</param>
        /// <param name="range">The range to add.</param>
        /// <param name="comment">The comment for the new named range.</param>
        IXLNamedRange Add(String rangeName, IXLRange range, String comment);

        /// <summary>
        /// Adds a new named range.
        /// </summary>
        /// <param name="rangeName">Name of the ranges to add.</param>
        /// <param name="ranges">The ranges to add.</param>
        /// <param name="comment">The comment for the new named range.</param>
        IXLNamedRange Add(String rangeName, IXLRanges ranges, String comment);

        /// <summary>
        /// Deletes the specified named range (not the cells).
        /// </summary>
        /// <param name="rangeName">Name of the range to delete.</param>
        void Delete(String rangeName);

        /// <summary>
        /// Deletes the specified named range's index (not the cells).
        /// </summary>
        /// <param name="rangeIndex">Index of the named range to delete.</param>
        void Delete(Int32 rangeIndex);


        /// <summary>
        /// Deletes all named ranges (not the cells).
        /// </summary>
        void DeleteAll();

        Boolean TryGetValue(String name, out IXLNamedRange range);

        Boolean Contains(String name);

        /// <summary>
        /// Returns a subset of named ranges that do not have invalid references.
        /// </summary>
        IEnumerable<IXLNamedRange> ValidNamedRanges();

        /// <summary>
        /// Returns a subset of named ranges that do have invalid references.
        /// </summary>
        IEnumerable<IXLNamedRange> InvalidNamedRanges();
    }
}
