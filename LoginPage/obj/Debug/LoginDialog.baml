   M S B A M L   `   `   `  ����G  CBookStoreGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LoginPage	LoginPage  5   	       BookStoreGUI.LoginDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LoginPage     5   	     � Title$  Login��5   	   $	��150��6   $	��400��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   $��95��6,   �� 5      $
��Auto �6   $	��612��6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��31��6*   �� 5      $
��Auto �6   $	��105��6*   �� 5      $
��Auto �6   $��35��6*   .+�5   
   �� $��1��6   $��2��6%   $	��Top=�62    �� Orientation$ 
Horizontal=�5      $
��Left=�6.   $	��280��6I   $��0,10,0,0q�6U   $��47��6g   .+�5      �� -   5         ��Name$ okButton��5       �� 	IsDefault . $��OK��68   $	��100��6E   $��1q�6k   $��	0,0,80,22q�5      $��25��6(   �� 5      -   5        $ cancelButton��5       �� IsCancel . $��Cancel��6;   $	��100��6L   $��0,0,0,22q�5      6'   5      �� 5   
   $��
User Name:��6   $
��Left=�6%   $��	10,14,0,0q�6@   $	��Top=�6S   $��25��5      $��80��6   �� 5   
   -   5         ��Name$ nameTextBox��5      $��1��6'   $
��Left=�67   $��25��6R   $��0,14,0,0q�6^    �� TextWrapping$
 Wrap=�5      $�� ��6&   $	��Top=�6.   $	��280��6F   �� 5   
   $��	Password:��6   $��10,5,0,0q�6$   $	��Top=�66   $��26��6N   $��1��6Z   G� 5    
   -   5        	 G�Name$	 passwordTextBox��5       $
��Left=�6/   $��25��6J   $��0,6,0,0q�6V   $	��Top=�5!      $	��280��6*   $��1��66   $��1��6C   5#      5$      