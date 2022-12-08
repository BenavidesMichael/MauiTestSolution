using MauiTest.Modules.Shop.Models;

namespace MauiTest.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Product;

            if (!product.HasOffer) 
            {
                //Style qui non pas d'offres
                Application.Current
                           .Resources
                           .TryGetValue("ProductTemplateStyle", out var productTemplateStyle);
                
                return productTemplateStyle as DataTemplate;
            }
            else
            {
                Application.Current
                           .Resources
                           .TryGetValue("ProductWithOfferStyle", out var productWithOfferStyle);
                return productWithOfferStyle as DataTemplate;
            }
        }
    }
}
