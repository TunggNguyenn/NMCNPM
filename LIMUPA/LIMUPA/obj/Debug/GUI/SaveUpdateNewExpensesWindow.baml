   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	   ,    &LIMUPA.GUI.SaveUpdateNewExpensesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	     � Title$  AddNewExpenses��5   	    � WindowStyle$
 None=�6     � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�5	   	   $	��350��6   $
��1000��6,   $��Segoe UI Emoji)�5
   	   $��1q�5   	   
���� ��.��5      � .+�5   
   �� $��40��6   $	��Top=�6    ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      .@�5      �� .��5      �� .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/info.png��6    	 �� BitmapScalingMode$	 HighQuality=�6:   �� 5      $��ADD NEW EXPENSES��6$   $��20(�6<   $��5,0,0,0q�6J   $
��Bold"�6[   5      5      5      �� 5      $��Right=�6   $��55��68   .��5      �� -   5        
 ��Name$
 
exitButton��5      
����  �$��34��6X   .��5      �� $��/Images/x-button.png��6   $	 HighQuality=�6:   5       5!      5"      � 5$   
   $	��Top=�6   $��0,40,0,0q�6'    � RowDefinitions 5%      �� 5&      $��40 �6    �� 5'      $��40 �6    �� 5(      $��40 �6    �� 5)      $��40 �6    �� 5*      $��40 �6    �� 5+      $��40 �6    �� 5,      $��60 �6    .+�5/      �� $��0��6   $ 
Horizontal=�6&   .+�50      �� $��DATE:   ��6   $��10,0,0,0q�6,   $
��Bold"�6>   
���  ��$��30(�6a   (  "System.Windows.Controls.DatePicker  51      -   5        $
��date��51      $	��180��6)   $��40��65   $��30(�6A   
����  �$��5,0,0,0q�6a   �� 52      $��	TOTAL:   ��6   $��	250,0,0,0q�6-   $
��Bold"�6@   
���  ��$��30(�6c   �� 53      -   5         ��Name$ totalTextBlock��53      $��0��64   $	��200��6=    �� TextAlignment$ Center=�6I   $��Italic$�6`   
����  �$��26(�6�   �� 54      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   55      �� 57      $��1��6   $ 
Horizontal=�6&   $��Center=�6?   .+�58      �� $��ELECTRIC:   ��6   $	��180��60   $��10,0,0,0q�6<   $
��Bold"�6N   
���  ��$��30(�6q   �� 59      -   5         ��Name$ electricTextBox��59      $��0��64   $	��200��6g    �� TextAlignment$ Center=�6s   $��Italic$�6�   
����  �$��26(�6�   �� 5:      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   5;      �� 5=      $��2��6   $ 
Horizontal=�6&   $��Center=�6?   .+�5>      �� $��	WATER:   ��6   $	��180��6-   $��10,0,0,0q�69   $
��Bold"�6K   
���  ��$��30(�6n   �� 5?      -   5        $ waterTextBox��5?      $��0��61   $	��200��6a   $ Center=�6m   $��Italic$�6�   
����  �$��26(�6�   �� 5@      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   5A      �� 5C      $��3��6   $ 
Horizontal=�6&   $��Center=�6?   .+�5D      �� $��PREMISES:   ��6   $	��180��60   $��10,0,0,0q�6<   $
��Bold"�6N   
���  ��$��30(�6q   �� 5E      -   5        $ premisesTextBox��5E      $��0��63   $	��200��6f   $ Center=�6r   $��Italic$�6�   
����  �$��26(�6�   �� 5F      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   5G      �� 5I      $��4��6   $ 
Horizontal=�6&   $��Center=�6?   .+�5J      �� $��
SALARY:   ��6   $	��180��6.   $��10,0,0,0q�6:   $
��Bold"�6L   
���  ��$��30(�6o   �� 5K      -   5        $ salaryTextBox��5K      $��0��61   $	��200��6b   $ Center=�6n   $��Italic$�6�   
����  �$��26(�6�   �� 5L      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   5M      �� 5O      $��5��6   $ 
Horizontal=�6&   $��Center=�6?   .+�5P      �� $��	GOODS:   ��6   $	��180��6-   $��10,0,0,0q�69   $
��Bold"�6K   
���  ��$��30(�6n   �� 5Q      -   5        $ goodsTextBox��5Q      $��0��6W   $	��200��6`   $ Center=�6l   $��Italic$�6�   
����  �$��26(�6�   �� 5R      $��(VNĐ)��6   $��Italic$�6+   
���  ��$��26(�6O   5S      �� 5V      $��6��6   $ 
Horizontal=�6&   $��Right=�6?   .+�5W      �� -	   5        $
 
saveButton��5W      $��0,0,30,0q�6F   
��� � �
�������$��2q�6~   $��40��6�   $
��Bold"�6�   $	��120��6�   $
��SAVE��6�   $��Center=�6�   $��Right=�6�   �� 5X      -
   5        $
 updateButton��5X      $y�	Collapsed=�6J   $��0,0,30,0q�6a   
��� � �
�������$��2q�6�   $��40��6�   $
��Bold"�6�   $	��120��6�   $��UPDATE��6�   $��Center=�6�   $��Right=�6  �� 5Y      -   5        $
 cancelButton��5Y      $��0,0,50,0q�6K   
�������$��2q�6p   $��40��6�   $
��Bold"�6�   $	��120��6�   $��CANCEL��6�   $��Center=�6�   $��Right=�6�   5Z      5[      5\      5]      