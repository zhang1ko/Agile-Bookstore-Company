   M S B A M L   `   `   `  ����  BookStoreGUI    BookStoreGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  Agile BookStore Company��5	   	   $	��575��6)   $	��550��66   .��5
      � .+�5      �� -   5         ��Name$ 
LayoutRoot��5       �� Orientation$ Vertical=�5      $
��Left=�6   $
��auto��68   $
��auto��6F    � DataContext 5   +   �� .+�5      �� $ 
Horizontal=�6   $
��Left=�65   .+�5      �� $��Categories:��6   $��	18,10,0,8q�62   �� 5      -   5         ��Name$ categoriesComboBox��5   7   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5       �� DisplayMemberPath$
 Name��5      $��23��6    $��12q�6,   $	��200��68   ��5      �� ��5      �� 5       .R�5   %   $� 5   !   5      �� 5      -   5         ��Name$ loginButton��5   9   $��Login��6   $��25��6-   $��75��5      $��28,0,0,2q�6   6$   �� 5      -   5        $ 
exitButton��5   8   $
��Exit��6   $��25��6,   $��75��5      $��20,0,0,2q�6   6$   5       &   System.Windows.Controls.DataGrid  5"      -   5          Name$ ProductsDataGrid��5$      	   AutoGenerateColumns	 .  $	��165��5"   6   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�5$      $	��490��5%      $
��Left=�6   $��
20,0,20,10q�6*      SelectionMode$ Single=�5&         CanUserAddRows .     AlternatingRowBackground
 �����   GridLinesVisibility$
 None=�6R   ��5#      �� *
drCat_Book+   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      -   5        titleColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Title��5+         Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6"   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*   (   �� *Title+   ElementStyle 5,       �� 5-   %    �� 
TargetType" ��6+   .�5.   *   ��  �� Property � �� �� Value$ CharacterEllipsis=�6I   �� 5/   *    �@�ToolTip 6D   �� *Text+ �� RelativeSource �� *Self+51   &   53        54      -   5        authorColumn��$ Author��56      $	 18* 6    55      �� *Author+56        57      -	   5        priceColumn��$ Price��59      $	 12* 6      CanUserSort .   58   #   �� *Price+   HeaderStyle 5:       �� 5;   %   =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6+   .�5<   *   ��  � ��$ Right=�6W   5=   &    5?       �� 5@   %   " ��6+   .�5A   *   ��  � ��$ Right=�6P   5B   &   5D        5E      -
   5        
yearColumn��$
 Year��5G      $ 8* 6    5F      �� *Year+5G      5I      �� 5K      $ 
Horizontal=�6   $��0,0,0,0q�65   .+�5M      �� -   5        $ searchComboBox��5M      $��23��67   $��20,0,0,0q�6C   $	��100��6U   ��5N      �� 5O       .R�5P   %   $� 5Q   !   .@�5S      �� $��Title��6(   $
��Left=�68   $��20��6S   $	��Top=�6_   $��98��6w   �� 5T      $��Author��6(   $
��Left=�69   $��20��6T   $	��Top=�6`   $��98��6x   �� 5U      $��Price��6(   $
��Left=�68   $��20��6S   $	��Top=�6_   $��98��6w   �� 5V      $
��Year��6(   $
��Left=�67   $��20��6R   $	��Top=�6^   $��98��6v   5W      �� 5Y      -   5         ��Name$ textBox1��5Y      $��25��6S    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��357��6{   $��30,0,0,0q�6�   5Z      �� 5]      $ Vertical=�6   $��0,10,0,0q�63   .+�5_      �� -   5         ��Name$ orderListView��5_      $	��150��66   $	��490��6F    �� SelectionMode$ Single=�5`      ��6   ��  �� View 5a      �� 5c       .P�5d   %   ��  �� Width$ 80��64   $
��ISBN��6?     �� DisplayMemberBinding  5e      �� *BookID+�� 5f   %   $	 285��64   $��Title��6@     5g      �� *	BookTitle+�� 5h   %   $ 60��64   $��Quantity��6?     5i      �� *
Quantity+�� 5j   %   $ 60��64   $��Subtotal��6?     5k      �� *
SubTotal+5l   !   5n      5o      �� 5p      $ 
Horizontal=�6   $��
307,0,21,0q�65   $	��200��6I   .+�5q      �� $
��Left=�6    $��	10,10,0,0q�6;   $
��Wrap=�6N   $��Total:��6b   $	��Top=�6p   �� 5r      -   5        $��totalTextBox��5r      $
��Left=�62   $��23��6M   $��33,8,0,0q�6Y   $
 Wrap=�6k   $��$��6   $	��Top=�6�   $	��129��6�   {�.  6�   5s      �� 5t      $ 
Horizontal=�6   $��Center=�65   $��10q�6R   .+�5v      �� -   5        $ register��5v      $��25��6/   $��80��6>   $��0,0,0,0q�6L   $��Register��5w      6   �� 5y      -   5        $ 	addButton��5y      $��25��60   $��80��6?   $��10,0,0,0q�6M   $��Add Book��5z      6"   �� 5|      -   5        $ removeButton��5|      $��25��63   $��80��6B   $��Remove Book��5}      $��10,0,0,0q�6K   �� 5      -   5        $ previewButton��5      $��25��64   $��80��6C   $��Preview Book��5�      $��10,0,0,0q�6M   �� 5�      -   5        $ checkoutOrderButton��5�      $��25��6:   $��80��6I   $��Proceed to Checkout��5�      $	��121��6N   $��9,0,0,0q�6Z   5�      �� 5�      $ 
Horizontal=�6   $
��Left=�65   $��25,0,0,0q�6P   .+�5�      �� -   5        $ editProfile��5�      $��25��62   $��80��6A   $��Edit Profile��5�      $��0,0,0,0q�68   $y�Hidden=�6I   �� 5�      -   5        $ wishListButton��5�      $��25��65   $��80��6D   $��Wishlist��5�      $��10,0,0,0q�6J   $y�Hidden=�6\   �� 5�      -   5        $ orderHistoryButton��5�      $��25��69   $��80��6H   $��10,0,0,0q�6V   $��Order History��5�      $y�Hidden=�6:   �� 5�      -   5        $ adminButton��5�      $��25��62   $	��121��6A   $��99,0,0,0q�5�   7   $��Administration��6J   $y�Hidden=�6d   5�      5�      �� 5�      $��Bottom=�6   $��Stretch=�61   .@�5�      �� -   5        ! ��Name$! statusTextBlock��5�      �� 65   $1�+Please login before proceeding to checkout.��69   6o   5�      5�      5�      