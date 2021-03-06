﻿using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WebHelpers.Mvc5.JqGrid;

namespace WebHelpers.Mvc5
{
    /// <summary>
    /// Extensions for <see cref="HtmlHelper"/>.
    /// </summary>
    public static class HtmlHelperExtensions
    {
#if DEBUG
        public static IHtmlString JqGrid(this HtmlHelper helper)
        {
            var grid = new Grid
            {
                /*
                 * colModel: [
                    { label: 'Category Name', name: 'CategoryName', width: 100, frozen: true },
                    { label: 'Product Name', name: 'ProductName', width: 150, frozen: true },
                    { label: 'Country', name: 'Country', width: 200 },
                    { label: 'Price', name: 'Price', width: 250, sorttype: 'number' },
                    { label: 'Quantity', name: 'Quantity', width: 250, sorttype: 'integer' }                   
                ],
                 */
                Columns = new List<Column>
                {
                    new Column
                    {
                        Name = "CategoryName"
                    },
                    new Column
                    {
                        Name = "ProductName"
                    },
                    new Column
                    {
                        Name = "Country"
                    },
                    new Column
                    {
                        Name = "Price"
                    },
                    new Column
                    {
                        Name = "Quantity"
                    },
                    new Column
                    {
                        Name = "ACT",
                        FormatterName = "Fmt"
                    }
                    //new Column
                    //{
                    //    Name = "Second",
                    //    Align = TextAlign.Right,
                    //    IsHidden = true
                    //},
                    //new Column
                    //{
                    //    Name = "Test",
                    //    Class = "ui-ellipsis",
                    //    IsEditable = true,
                    //    EditAttributes = new { cacheDataUrl = true, delimiter = "|" },
                    //    FormatterName = IntegerColumnFormatOptions.Name,
                    //    FormatOptions = new IntegerColumnFormatOptions
                    //    {
                    //        ThousandsSeparator = " "
                    //    }
                    //},
                    //new Column
                    //{
                    //    Name = "LinkCol",
                    //    FormatterName = ActionColumnFormatOptions.Name,
                    //    FormatOptions = new ActionColumnFormatOptions
                    //    {
                    //        IsKeyBindingEnabled = true
                    //    }
                    //}
                }
            };
            
            return new MvcHtmlString(grid.ToString());
        }
#endif
    }
}
