Feature: Paytm Website Validation
	To test if the paytm website has all the elements present 
	And to validate the mobile page

@mytag
Scenario: Successful Validation of Paytm Website 
	Given That paytm is opened in the web browser
	When Inside the paytm website 
	Then there should be Mobile,Electricity,DTH,Metro
Scenario: Successful Mobile Recharge
	Given That paytm is opened in the web browser
	And I navigate to Mobile Tab
	And Then enter the Mobile number,Amount
	When Clicked on proceed to recharge
	Then it should redirect to 'https://paytm.com/coupons'

