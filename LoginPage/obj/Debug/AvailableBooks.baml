   M S B A M L   `   `   `  ����G  CBookStoreGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreGUIBookStoreGUI  5   	   !    BookStoreGUI.AvailableBooks   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreGUI     5   	     � Title$3  -These books in your wishlist are now avaiable��5   	   $��236.8��6?   $	��536��6N   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��159* �6   �� 5      $	��85* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��2��6,   $��0,0,-0.2,-0.2q�6@   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ AvailableBookView��5         AutoGenerateColumns .  $	��165��6N      RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $	��490��5      $
��Left=�6   $��
20,0,20,10q�6*      SelectionMode$ Single=�5      ��5   	   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6B   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� *ISBN+6B     5      -   5        titleColumn��
   Header$
 Title��5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6   	 5   %   �� *Title+5        5      -   5        authorColumn��$
 Author��5      $	 18* 6    $ Hidden=�6,   	 5   &   �� *Author+5   ,     5      -   5        priceColumn��$
 Price��5      $	 12* 6      CanUserSort .  $ Hidden=�6?   	 5   %   �� *Price+5   ?     5       -   5        
yearColumn��$

 Year��5"      $ 8* 6   $ Hidden=�6)   	 5!   $   �� *Year+5"   )   5$      5%      �� 5'   
   $ 
Horizontal=�6   $��Center=�6.   $��186,10,16.4,9.8q�6K   .+�5(      �� -   5         ��Name$ 	addButton��5(      $��80��6)   $��Add to Order��5)      $��10,159,0,0.2q�6J   $	��106��6`   5*      5+      5,      