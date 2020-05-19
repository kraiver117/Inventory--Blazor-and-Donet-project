#pragma checksum "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a8e8d1018319ee4031f843eea28cd01e4445a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Exercises.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Exercises.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.WareHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Angel\source\repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.AddMarkupContent(1, "<label><b>Filtro de búsqueda</b></label>\r\n");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                        CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    \r\n    ");
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "value", "Seleccione categoria:");
            __builder.AddContent(8, "Seleccione una categoria:");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 12 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
     foreach (var category in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 14 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                        category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                              category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 15 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<hr>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-hover border-primary");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<thead>\r\n        <tr>\r\n            <th>Referencia</th>\r\n            <th>Nombre producto</th>\r\n            <th>Categoria</th>\r\n            <th>Cantidad</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 32 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
         foreach (var product in tempProducts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 35 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 36 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 37 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 38 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.TotalQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "product/update/" + (
#nullable restore
#line 39 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                             product.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 41 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.AddContent(46, 
#nullable restore
#line 46 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Angel\source\repos\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
       
    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tempProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    string message;

    protected override async Task OnInitializedAsync()
    {
        products = bProduct.ProductList();
        tempProducts = products; //Variable para no hacer demasiadas llamadas a la base de datos
        categories = bCategory.CategoryList();
    }

    private void CategoryChanged(ChangeEventArgs e)
    {
        //message = e.Value.ToString();
        tempProducts= products.Where(c=>c.CategoryId==e.Value.ToString()).ToList();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Category bCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Product bProduct { get; set; }
    }
}
#pragma warning restore 1591
