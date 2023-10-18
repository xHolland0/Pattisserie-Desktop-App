**Patisserie Desktop App**

**- First**

Administrators will be able to log in as Administrator and enter data through the interface, check and delete the entered data.
Customers will be able to view the data entered by administrators and access the purchasing process in the same way.

With this Short-Scale project, Patisserie managers will be able to manage their workplaces with a simple interface. In this way, they will be able to run a much more successful business.

Here is a simple flow chart:

```mermaid
erDiagram
    ORDER ||--o{ PRODUCT : Contains
    ORDER {
int Id
int CustomerId
int ProductId
Date Date
    }

    ORDER-DETAIL ||--o{ ORDER-PRODUCT : Places
    ORDER-DETAIL {
int Id
int OrderId
int ProductId
int Quantity
int TotalPrice
    }

    PRODUCT ||--o{ CATEGORY : Is
    PRODUCT {
int Id
string Name
string Description
int Price
int CategoryId
int Calorie
    }
    CATEGORY {
int Id
string Name
    }
```
  Database Schema to Follow      
![ss1](https://github.com/xHolland41/Pattisserie-Desktop-App/assets/81883631/055827ae-837b-4c84-8b88-5b7485ff2da3)

