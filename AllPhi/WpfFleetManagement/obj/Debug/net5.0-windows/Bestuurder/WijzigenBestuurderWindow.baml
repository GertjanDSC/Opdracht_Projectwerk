   M S B A M L   `   `   `  ����M  IWpfFleetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfFleetManagementWpfFleetManagement  5   	   1    +WpfFleetManagement.WijzigenBestuurderWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfFleetManagement     5   	     � Title$  WijzigenBestuurderWindow��5   	   $	��600��6*   $
��1000��67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6    $��Voornaam��6-   $��5q�6@   �� 5   
   -   5         ��Name$ Wijzig_VoornaamTextbox��5      $��0��62   $��0��6?   $��	5,30,5,10q�6P   �� 5   
   $��1��6   $��0��6    $
��Naam��6-   $��5q�6<   �� 5   
   -   5        $ Wijzig_NaamTextbox��5      $��0��6.   $��1��6;   $��	5,30,5,10q�6L   �� 5   
   $��0��6   $��1��6    $��Geboortedatum��6-   $��5q�6E   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$$ Wijzig_GeboortedatumDatePicker��5      $��1��6=   $��0��6J   $��	5,30,5,10q�6[   �� 5    
   $��1��6   $��1��6    $��Rijksregisternummer��6-   $��5q�6K   �� 5!   
   -   5        $' !Wijzig_RijksregisternummerTextbox��5!      $��1��6=   $��1��6J   $��	5,30,5,10q�6[   �� 5#   
   $��0��6   $��2��6    $��Straat��6-   $��5q�6>   �� 5$   
   -   5        $ Straat_wijzigscherm��5$      $��2��6/   $��0��6<   $��	5,30,5,10q�6M   �� 5&   
   $��1��6   $��2��6    $
��Stad��6-   $��5q�6<   �� 5'   
   -   5        $ Stad_wijzigscherm��5'   /   $��2��6   $��1��6   $��	5,30,5,10q�6K   �� 5)   
   $��0��6   $��3��6    $��Postcode��6-   $��5q�6@   �� 5*   
   -   5        $ Postcode_wijzigscherm��5*   /   $��3��6   $��0��6   $��	5,30,5,10q�6O   �� 5,   
   $��1��6   $��3��6    $��
Huisnummer��6-   $��5q�6B   �� 5-   
   -   5        $ Huisnummer_wijzigscherm��5-   /   $��3��6   $��1��6   $��	5,30,5,10q�6P   �� 55   
   $��0��6   $��4��6    $��5q�6-   $��Rijbewijzen��68   $	��100��6N   $��30��6Z   $	��Top=�6f   $
��Left=�6~   � 56   
   $��2��6   $��4��6$   $��5q�61    57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      .+�5@      �� -	   5         ��Name$! Wijzig_RijbewijsCheckbox_AM��5@      $��0��6<   $��Center=�6L   $��Center=�6g   .��6�   AM6�   �� 5A      -
   5        $  Wijzig_RijbewijsCheckbox_A��5A      $��1��6;   $��Center=�6K   $��Center=�6f   .��6�   A6�   �� 5B      -   5        $! Wijzig_RijbewijsCheckbox_A1��5B      $��2��6<   $��Center=�6L   $��Center=�6g   .��6�   A16�   �� 5C      -   5        $! Wijzig_RijbewijsCheckbox_A2��5C      $��3��6<   $��Center=�6L   $��Center=�6g   .��6�   A26�   �� 5D      -   5        $  Wijzig_RijbewijsCheckbox_B��5D      $��4��6;   $��Center=�6K   $��Center=�6f   .��6�   B6�   �� 5E      -   5        $! Wijzig_RijbewijsCheckbox_BE��5E      $��5��6<   $��Center=�6L   $��Center=�6g   .��6�   BE6�   �� 5F      -   5        $  Wijzig_RijbewijsCheckbox_C��5F      $��6��6;   $��Center=�6K   $��Center=�6f   .��6�   C6�   5G      � 5H   
   $��2��6   $��5��6$   $��5q�61    5I      �� 5J      �� 5K      �� 5L      �� 5M      �� 5N      �� 5O      �� 5P      .+�5R      �� -   5        $! Wijzig_RijbewijsCheckbox_CE��5R      $��0��6<   $��Center=�6L   $��Center=�6g   .��6�   CE6�   �� 5S      -   5        $  Wijzig_RijbewijsCheckbox_D��5S      $��1��6;   $��Center=�6K   $��Center=�6f   .��6�   D6�   �� 5T      -   5        $! Wijzig_RijbewijsCheckbox_DE��5T      $��2��6<   $��Center=�6L   $��Center=�6g   .��6�   DE6�   �� 5U      -   5        $! Wijzig_RijbewijsCheckbox_D1��5U      $��3��6<   $��Center=�6L   $��Center=�6g   .��6�   D16�   �� 5V      -   5        $" Wijzig_RijbewijsCheckbox_D1E��5V      $��4��6=   $��Center=�6M   $��Center=�6h   .��6�   D1E6�   �� 5W      -   5        $  Wijzig_RijbewijsCheckbox_T��5W      $��5��6;   $��Center=�6K   $��Center=�6f   .��6�   T6�   5X      �� 5Z   
   -   5         ��Name$ WijzigButton��5Z      $��2��6D   $��6��6X   $��5q�6e   .��6p   Wijzig6x   5[      5\      