   M S B A M L   `   `   `  ����F  BRentalStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RentalStoreRentalStore  5          RentalStore.Main   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RentalStore     5      -   5          N� 
Background
  ����� N� Title$
 Main��5
       � 	Resources 5         overdue �� 
TargetType �� Property �� Value �� Path  customersTemplate  moviesTemplate��%  &	        &	 U     &	 �     7   �� 5   
   " ��6    .�5      ��  � �� 6+   �� $ Colour�5      �� 5   
   .R�5      �� ��6   �� $ 	Firstname�6:   5      �� 5   
   .R�5      �� 8��  ��6   �� $ MyMovie�6Y   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $	��17* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��250,10q�6   $��Center=�6%   $��2��6B   $��3��6V   .+�5!      �� $��Center=�6   $��Movie Rental Pro V1��65   $��24(�6P   �� 5"      $��Center=�6   $��2��62   
����  �$	��300��6O   	 �� CornerRadius$		 100��6[   6p   5#      �� 5$   
   -   5        
 ��Name$
 lbxCustomers��5$      #��[ 6(   $��50,20q�6Z   $��1��6i   �� 5%   
   -   5        $
 	lbxMovies��5%      #��[ 6%   $��50,20q�6T   $��1��6c   $��1��6s   �� 5&   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Center=�6O   .+�5'      �� -   5         ��Name$ btnRegister��5'      $��Register Customer��6*   $	��Top=�6F   $��55��6^   $	��150��6j   $��5q�6�   �� 5(      -   5        $ btnViewProfile��5(      $��View Customer History��6-   $	��Top=�6M   $	��150��6e   $��55��6�   $��5q�6�   �� 5)      -   5        $ btnCreateLoan��5)      $��Create Loan��6,   $	��Top=�6B   $	��150��6Z   $��55��6x   $��5q�6�   �� 5*      -   5        $ 	btnReturn��5*      $��Return Movie��6(   $	��Top=�6?   $	��150��6W   $��55��6c   $��5q�6�   5+      �� 5,   
   $��	Customers��6   $��16(�6$   $
��Left=�62   $��
165,47,0,0q�6M   $	��Top=�6a   $��40��6y   $��2��6�   �� 5-   
   $��
Movies Out��6   $��16(�6%   $��1��63   $
��Left=�6C   $��
155,47,0,0q�6^   $	��Top=�6r   $��40��6�   $��2��6�    J� RenderTransformOrigin$ 0.498,0.225&�6�   50      51      