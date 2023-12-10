The solution container following patterns:
1> Iterator, implemented by CouponsCollection & SaleItemsCollection classes
2> Factories implemented for creating Rental, Sales or Free Item Pricing. There are also factories for creating Coupon and MovieRental Factories. The MovieRental Factory handles pricing for New, Regular or Children Movie SubTypes Pricing.
3> Strategies, there are Pricing strategies implemented for Books, Movies, MusicCD, Ps4, VideoGames & XBox. Each strategy has Rental as well Sale pricing strategy. Additionally, Movie has pricing strategies based on New, Regular or Children Movie type rentals.
4> Decorators, there are decorators implemented to handle coupon discounts on items. The EarlyPromotion and PercentDiscounts apply per item discounts. While Cart, FreeItem and Loyalty discounts apply at cart level.
5> Null Object (Default object), the pattern is implemented to handle NoDiscount or FreePricing strategies as needed.
6> Facade, is implemented by the PurchaseOrchestrationFacade class to demonstrate how it can simply interface, to provide clarity overall business process.
7> As Store manager, we can provide a `Free` items to users as well, demonstrated by GetStoreManagerGift() Facade call.
8> FrequentRenterPoints have been renamed to LoyaltyPoints.


The solution is able to handle per item discounts as well a transaction based discount. The receipt shows, customer name, total purchase amount and date of receipt. Also it shows final cost of each item, and discounts applied.


The final output in form of XML receipt is 
```Xml
<Purchases Customer="Yatin Shah" LoyaltyPoints="6">
	<Receipt Name="Christmas Purchases" TotalAmount="$112.19" Date="12/10/2023 2:24:30 AM">

		<Item SaleType="Sale" Quantity="3" ProductType="MusicCD" ProductSubType="None" Price="$1.00" Cost="$3.00"/>
		<Item SaleType="Sale" Quantity="1" ProductType="XBox" ProductSubType="None" Price="$38.25" Cost="$38.25"/>
		<Item SaleType="Sale" Quantity="1" ProductType="Ps4" ProductSubType="None" Price="$34.00" Cost="$34.00"/>
		<Item SaleType="Sale" Quantity="10" ProductType="Book" ProductSubType="None" Price="$1.70" Cost="$17.00"/>
		
		<Item SaleType="Free" Quantity="10" ProductType="FreeItem" ProductSubType="None" Price="$0.00" Cost="$0.00"/>
		
		<Item SaleType="Rental" RentalDays="5" ProductType="VideoGame" ProductSubType="None" Price="$24.00" Cost="$24.00"/>

		<Item SaleType="Rental" RentalDays="1" ProductType="Movie" ProductSubType="Regular" Price="$2.80" Cost="$2.80"/>
		<Item SaleType="Rental" RentalDays="1" ProductType="Movie" ProductSubType="Children" Price="$2.80" Cost="$2.80"/>
		<Item SaleType="Rental" RentalDays="1" ProductType="Movie" ProductSubType="New" Price="$2.80" Cost="$2.80"/>
		
		<Item SaleType="Free" Quantity="1" ProductType="MusicCD" ProductSubType="None" Price="$0.00" Cost="$0.00"/>
		<Item SaleType="Free" Quantity="1" ProductType="Book" ProductSubType="None" Price="$0.00" Cost="$0.00"/>

		<LoyaltyDiscount LoyaltyUsed="-5" _="Free MusicCD added to purchases."/>
		<CartDiscount Amount="-12.465"/>
		<FreeDiscount _="Free Book added to purchases."/>
	</Receipt>
</Purchases>
```