//ş
using System;
using ClosedXML.Excel;

namespace ClosedXML.Extensions {
    public static class XIXLRange {
        public static IXLRangeRow SingleRowRange (this IXLRange range, IXLAddress anchorCellAddress, Int32 numberOfColumns, Boolean fromRightToLeft = false) {
            return range.SingleRowRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfColumns: numberOfColumns,
                fromRightToLeft: fromRightToLeft
            );
        }

        public static IXLRangeRow SingleRowRange (this IXLWorksheet range, IXLAddress anchorCellAddress, Int32 numberOfColumns, Boolean fromRightToLeft = false) {
            return range.SingleRowRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfColumns: numberOfColumns,
                fromRightToLeft: fromRightToLeft
            );
        }

        public static IXLRangeRow SingleRowRange (this IXLRange range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfColumns, Boolean fromRightToLeft = false) {
            return range.RelativeRange(
                anchorCellRow: anchorCellRow,
                anchorCellColumn: fromRightToLeft ? anchorCellColumn - numberOfColumns + 1 : anchorCellColumn,
                numberOfRows: 1,
                numberOfColumns: numberOfColumns
            )
            .Row(1);
        }

        public static IXLRangeRow SingleRowRange (this IXLWorksheet range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfColumns, Boolean fromRightToLeft = false) {
            return range.RelativeRange(
                anchorCellRow: anchorCellRow,
                anchorCellColumn: fromRightToLeft ? anchorCellColumn - numberOfColumns + 1 : anchorCellColumn,
                numberOfRows: 1,
                numberOfColumns: numberOfColumns
            )
            .Row(1);
        }

        public static IXLRangeColumn SingleColumnRange (this IXLRange range, IXLAddress anchorCellAddress, Int32 numberOfRows, Boolean fromBottomToTop = false) {
            return range.SingleColumnRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfRows: numberOfRows,
                fromBottomToTop: fromBottomToTop
            );
        }

        public static IXLRangeColumn SingleColumnRange (this IXLWorksheet range, IXLAddress anchorCellAddress, Int32 numberOfRows, Boolean fromBottomToTop = false) {
            return range.SingleColumnRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfRows: numberOfRows,
                fromBottomToTop: fromBottomToTop
            );
        }

        public static IXLRangeColumn SingleColumnRange (this IXLRange range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfRows, Boolean fromBottomToTop = false) {
            return range.RelativeRange(
                anchorCellRow: fromBottomToTop ? anchorCellRow - numberOfRows + 1 : anchorCellRow,
                anchorCellColumn: anchorCellColumn,
                numberOfRows: numberOfRows,
                numberOfColumns: 1
            )
            .Column(1);
        }

        public static IXLRangeColumn SingleColumnRange (this IXLWorksheet range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfRows, Boolean fromBottomToTop = false) {
            return range.RelativeRange(
                anchorCellRow: fromBottomToTop ? anchorCellRow - numberOfRows + 1 : anchorCellRow,
                anchorCellColumn: anchorCellColumn,
                numberOfRows: numberOfRows,
                numberOfColumns: 1
            )
            .Column(1);
        }

        public static IXLRange RelativeRange (this IXLRange range, IXLAddress anchorCellAddress, Int32 numberOfRows, Int32 numberOfColumns, Boolean fromBottomRightToTopLeft = false) {
            return range.RelativeRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfRows: numberOfRows,
                numberOfColumns: numberOfColumns,
                fromBottomRightToTopLeft: fromBottomRightToTopLeft
            );
        }

        public static IXLRange RelativeRange (this IXLWorksheet range, IXLAddress anchorCellAddress, Int32 numberOfRows, Int32 numberOfColumns, Boolean fromBottomRightToTopLeft = false) {
            return range.RelativeRange(
                anchorCellRow: anchorCellAddress.RowNumber,
                anchorCellColumn: anchorCellAddress.ColumnNumber,
                numberOfRows: numberOfRows,
                numberOfColumns: numberOfColumns,
                fromBottomRightToTopLeft: fromBottomRightToTopLeft
            );
        }

        public static IXLRange RelativeRange (this IXLRange range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfRows, Int32 numberOfColumns, Boolean fromBottomRightToTopLeft = false) {
            var p_firstCellRow = fromBottomRightToTopLeft ? anchorCellRow - numberOfRows + 1 : anchorCellRow;
            var p_firstCellColumn = fromBottomRightToTopLeft ? anchorCellColumn - numberOfColumns + 1 : anchorCellColumn;

            return range.Range(
                firstCellRow: p_firstCellRow,
                firstCellColumn: p_firstCellColumn,
                lastCellRow: p_firstCellRow + numberOfRows - 1,
                lastCellColumn: p_firstCellColumn + numberOfColumns - 1
            );
        }

        public static IXLRange RelativeRange (this IXLWorksheet range, Int32 anchorCellRow, Int32 anchorCellColumn, Int32 numberOfRows, Int32 numberOfColumns, Boolean fromBottomRightToTopLeft = false) {
            var p_firstCellRow = fromBottomRightToTopLeft ? anchorCellRow - numberOfRows + 1 : anchorCellRow;
            var p_firstCellColumn = fromBottomRightToTopLeft ? anchorCellColumn - numberOfColumns + 1 : anchorCellColumn;

            return range.Range(
                firstCellRow: p_firstCellRow,
                firstCellColumn: p_firstCellColumn,
                lastCellRow: p_firstCellRow + numberOfRows - 1,
                lastCellColumn: p_firstCellColumn + numberOfColumns - 1
            );
        }
    }
}
