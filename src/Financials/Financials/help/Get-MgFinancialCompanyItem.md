---
external help file: Microsoft.Graph.Financials-help.xml
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/get-mgfinancialcompanyitem
schema: 2.0.0
---

# Get-MgFinancialCompanyItem

## SYNOPSIS
Get items from financials

## SYNTAX

### List (Default)
```
Get-MgFinancialCompanyItem -CompanyId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [-Filter <String>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-PageSize <Int32>]
 [-All] [-CountVariable <String>] [<CommonParameters>]
```

### Get
```
Get-MgFinancialCompanyItem -CompanyId <String> -ItemId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgFinancialCompanyItem -InputObject <IFinancialsIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get items from financials

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -All
List all pages.

```yaml
Type: SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyId
key: id of company

```yaml
Type: String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IFinancialsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ItemId
key: id of item

```yaml
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: Int32
Parameter Sets: List
Aliases: Limit

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IFinancialsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItem
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IFinancialsIdentity\>: Identity Parameter
  \[AccountId \<String\>\]: key: id of account
  \[AgedAccountsPayableId \<String\>\]: key: id of agedAccountsPayable
  \[AgedAccountsReceivableId \<String\>\]: key: id of agedAccountsReceivable
  \[CompanyId \<String\>\]: key: id of company
  \[CompanyInformationId \<String\>\]: key: id of companyInformation
  \[CountryRegionId \<String\>\]: key: id of countryRegion
  \[CurrencyId \<String\>\]: key: id of currency
  \[CustomerId \<String\>\]: key: id of customer
  \[CustomerPaymentId \<String\>\]: key: id of customerPayment
  \[CustomerPaymentJournalId \<String\>\]: key: id of customerPaymentJournal
  \[DimensionId \<String\>\]: key: id of dimension
  \[DimensionValueId \<String\>\]: key: id of dimensionValue
  \[EmployeeId \<String\>\]: key: id of employee
  \[GeneralLedgerEntryId \<String\>\]: key: id of generalLedgerEntry
  \[ItemCategoryId \<String\>\]: key: id of itemCategory
  \[ItemId \<String\>\]: key: id of item
  \[JournalId \<String\>\]: key: id of journal
  \[JournalLineId \<String\>\]: key: id of journalLine
  \[PaymentMethodId \<String\>\]: key: id of paymentMethod
  \[PaymentTermId \<String\>\]: key: id of paymentTerm
  \[PictureId \<String\>\]: key: id of picture
  \[PurchaseInvoiceId \<String\>\]: key: id of purchaseInvoice
  \[PurchaseInvoiceLineId \<String\>\]: key: id of purchaseInvoiceLine
  \[SalesCreditMemoId \<String\>\]: key: id of salesCreditMemo
  \[SalesCreditMemoLineId \<String\>\]: key: id of salesCreditMemoLine
  \[SalesInvoiceId \<String\>\]: key: id of salesInvoice
  \[SalesInvoiceLineId \<String\>\]: key: id of salesInvoiceLine
  \[SalesOrderId \<String\>\]: key: id of salesOrder
  \[SalesOrderLineId \<String\>\]: key: id of salesOrderLine
  \[SalesQuoteId \<String\>\]: key: id of salesQuote
  \[SalesQuoteLineId \<String\>\]: key: id of salesQuoteLine
  \[ShipmentMethodId \<String\>\]: key: id of shipmentMethod
  \[TaxAreaId \<String\>\]: key: id of taxArea
  \[TaxGroupId \<String\>\]: key: id of taxGroup
  \[UnitOfMeasureId \<String\>\]: key: id of unitOfMeasure
  \[VendorId \<String\>\]: key: id of vendor

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/get-mgfinancialcompanyitem](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/get-mgfinancialcompanyitem)
