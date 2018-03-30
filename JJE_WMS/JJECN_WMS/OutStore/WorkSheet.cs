using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Spreadsheet;

namespace JJECN_WMS.OutStore
{
    class WorkSheet : Worksheet
    {
        public WorksheetView ActiveView
        {
            get { throw new NotImplementedException(); }
        }

        public void AddPrintRange(Range range)
        {
            throw new NotImplementedException();
        }

        public ArrayFormulaCollection ArrayFormulas
        {
            get { throw new NotImplementedException(); }
        }

        public CellCollection Cells
        {
            get { throw new NotImplementedException(); }
        }

        public DevExpress.Spreadsheet.Charts.ChartCollection Charts
        {
            get { throw new NotImplementedException(); }
        }

        public void Clear(Range range)
        {
            throw new NotImplementedException();
        }

        public void ClearComments(Range range)
        {
            throw new NotImplementedException();
        }

        public void ClearContents(Range range)
        {
            throw new NotImplementedException();
        }

        public void ClearFormats(Range range)
        {
            throw new NotImplementedException();
        }

        public void ClearHyperlinks(Range range)
        {
            throw new NotImplementedException();
        }

        public void ClearPrintRange()
        {
            throw new NotImplementedException();
        }

        public ColumnCollection Columns
        {
            get { throw new NotImplementedException(); }
        }

        public CommentCollection Comments
        {
            get { throw new NotImplementedException(); }
        }

        public IComparers Comparers
        {
            get { throw new NotImplementedException(); }
        }

        public ConditionalFormattingCollection ConditionalFormattings
        {
            get { throw new NotImplementedException(); }
        }

        public void CopyFrom(Worksheet source)
        {
            throw new NotImplementedException();
        }

        public ConditionalFormattingExtremumValue CreateConditionalFormattingExtremumValue()
        {
            throw new NotImplementedException();
        }

        public ConditionalFormattingExtremumValue CreateConditionalFormattingExtremumValue(ConditionalFormattingValueType valueType, string value)
        {
            throw new NotImplementedException();
        }

        public ConditionalFormattingIconSetInsideValue CreateConditionalFormattingIconSetInsideValue(ConditionalFormattingValueType valueType, string value, ConditionalFormattingValueOperator comparisonOperator)
        {
            throw new NotImplementedException();
        }

        public ConditionalFormattingInsideValue CreateConditionalFormattingInsideValue(ConditionalFormattingValueType valueType, string value)
        {
            throw new NotImplementedException();
        }

        public float DefaultColumnWidth
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float DefaultColumnWidthInCharacters
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int DefaultColumnWidthInPixels
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double DefaultRowHeight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DefinedNameCollection DefinedNames
        {
            get { throw new NotImplementedException(); }
        }

        public void DeleteCells(Range range, DeleteMode mode)
        {
            throw new NotImplementedException();
        }

        public void DeleteCells(Range range)
        {
            throw new NotImplementedException();
        }

        public void FreezeColumns(int columnOffset, Range topLeft)
        {
            throw new NotImplementedException();
        }

        public void FreezeColumns(int columnOffset)
        {
            throw new NotImplementedException();
        }

        public void FreezePanes(int rowOffset, int columnOffset, Range topLeft)
        {
            throw new NotImplementedException();
        }

        public void FreezePanes(int rowOffset, int columnOffset)
        {
            throw new NotImplementedException();
        }

        public void FreezeRows(int rowOffset, Range topLeft)
        {
            throw new NotImplementedException();
        }

        public void FreezeRows(int rowOffset)
        {
            throw new NotImplementedException();
        }

        public Range GetDataRange()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cell> GetExistingCells()
        {
            throw new NotImplementedException();
        }

        public Range GetPrintableRange(bool usePrintAreaDefinedName)
        {
            throw new NotImplementedException();
        }

        public Range GetPrintableRange()
        {
            throw new NotImplementedException();
        }

        public IList<Range> GetSelectedRanges()
        {
            throw new NotImplementedException();
        }

        public IList<Shape> GetSelectedShapes()
        {
            throw new NotImplementedException();
        }

        public Range GetUsedRange()
        {
            throw new NotImplementedException();
        }

        public WorksheetHeaderFooterOptions HeaderFooterOptions
        {
            get { throw new NotImplementedException(); }
        }

        public PageBreaksCollection HorizontalPageBreaks
        {
            get { throw new NotImplementedException(); }
        }

        public HyperlinkCollection Hyperlinks
        {
            get { throw new NotImplementedException(); }
        }

        public int Index
        {
            get { throw new NotImplementedException(); }
        }

        public void InsertCells(Range range, InsertCellsMode mode)
        {
            throw new NotImplementedException();
        }

        public void InsertCells(Range range)
        {
            throw new NotImplementedException();
        }

        public bool IsProtected
        {
            get { throw new NotImplementedException(); }
        }

        public void MergeCells(Range range, MergeCellsMode mode)
        {
            throw new NotImplementedException();
        }

        public void MergeCells(Range range)
        {
            throw new NotImplementedException();
        }

        public void Move(int position)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public PictureCollection Pictures
        {
            get { throw new NotImplementedException(); }
        }

        public WorksheetPrintOptions PrintOptions
        {
            get { throw new NotImplementedException(); }
        }

        public void Protect(string password, WorksheetProtectionPermissions permissions)
        {
            throw new NotImplementedException();
        }

        public ProtectedRangeCollection ProtectedRanges
        {
            get { throw new NotImplementedException(); }
        }

        public IRangeProvider Range
        {
            get { throw new NotImplementedException(); }
        }

        public RowCollection Rows
        {
            get { throw new NotImplementedException(); }
        }

        public void ScrollTo(Range scrolledAreaTopLeftCell)
        {
            throw new NotImplementedException();
        }

        public void ScrollTo(int rowIndex, int columnIndex)
        {
            throw new NotImplementedException();
        }

        public void ScrollToColumn(string columnHeading)
        {
            throw new NotImplementedException();
        }

        public void ScrollToColumn(int columnIndex)
        {
            throw new NotImplementedException();
        }

        public void ScrollToRow(string rowHeading)
        {
            throw new NotImplementedException();
        }

        public void ScrollToRow(int rowIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cell> Search(string text, SearchOptions options)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cell> Search(string text)
        {
            throw new NotImplementedException();
        }

        public Range SelectedCell
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DevExpress.Spreadsheet.Charts.Chart SelectedChart
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Picture SelectedPicture
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Shape SelectedShape
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Range Selection
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void SetPrintRange(Range range)
        {
            throw new NotImplementedException();
        }

        public bool SetSelectedRanges(IList<Range> ranges, bool expandToMergedCellsSize)
        {
            throw new NotImplementedException();
        }

        public bool SetSelectedRanges(IList<Range> ranges)
        {
            throw new NotImplementedException();
        }

        public bool SetSelectedShapes(IList<Shape> shapes)
        {
            throw new NotImplementedException();
        }

        public ShapeCollection Shapes
        {
            get { throw new NotImplementedException(); }
        }

        public void Sort(Range range, IEnumerable<SortField> sortFields)
        {
            throw new NotImplementedException();
        }

        public void Sort(Range range, int columnOffset, IComparer<CellValue> comparer)
        {
            throw new NotImplementedException();
        }

        public void Sort(Range range, int columnOffset, bool ascending)
        {
            throw new NotImplementedException();
        }

        public void Sort(Range range, bool ascending)
        {
            throw new NotImplementedException();
        }

        public void Sort(Range range, int columnOffset)
        {
            throw new NotImplementedException();
        }

        public void Sort(Range range)
        {
            throw new NotImplementedException();
        }

        public TableCollection Tables
        {
            get { throw new NotImplementedException(); }
        }

        public void UnMergeCells(Range range)
        {
            throw new NotImplementedException();
        }

        public void UnfreezePanes()
        {
            throw new NotImplementedException();
        }

        public bool Unprotect(string password)
        {
            throw new NotImplementedException();
        }

        public PageBreaksCollection VerticalPageBreaks
        {
            get { throw new NotImplementedException(); }
        }

        public WorksheetVisibilityType VisibilityType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Visible
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IWorkbook Workbook
        {
            get { throw new NotImplementedException(); }
        }

        public Cell this[int rowIndex, int columnIndex]
        {
            get { throw new NotImplementedException(); }
        }

        public Range this[string reference]
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<ExternalDefinedName> ExternalWorksheet.DefinedNames
        {
            get { throw new NotImplementedException(); }
        }

        public CellValue GetCellValue(int columnIndex, int rowIndex)
        {
            throw new NotImplementedException();
        }
    }
}
