   M S B A M L   `   `   `  ����G  CBookStoreGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreGUIBookStoreGUI  5   	   !    BookStoreGUI.WishlistDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreGUI     5   	     � Title$  WishlistDialog��5   	   $��178.4��6    $��271.2��6/   .��5	      � $��0,0,-0.4,-0.8q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��3��6   $��0��6$   $��2,2,2,2q�61   $��Center=�6B   .��6f   &$This book is currently out of stock.6�   �� 5   
   $��3��6   $��1��6$   $��2,2,2,2q�61   $��Center=�6B   .��6f   *(Do you want to add it to your wish list?6�   �� 5   
   $��0��6   $��3��6%   $��2��5       �� Orientation$ 
Horizontal=�6"   $��Right=�5      $��0,28,50.4,0q�61   $	��187��6F   .+�5      �� -   5         ��Name$ okButton��5       �� 	IsDefault . $��80��5      $��
12,10,5,18q�6#   $��23��67   $��23��6F   $��OK��6T   �� 5      -   5        $ cancelButton��5       �� IsCancel . $��80��5      $��5,10,5,17.8q�6#   $��23��68   $��23��6G   $��Cancel��6U   5      5      5       