   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LIMUPALIMUPA  5   	       LIMUPA.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:LIMUPA     5   	     � Title$  LIMUPA��5   	    � Icon$ /Images/shoppingLogo.png��6    �� BitmapScalingMode$ HighQuality=�68    � WindowState$ 	Maximized=�5	   	    � 
ResizeMode$ CanMinimize=�6!    � WindowStartupLocation$ CenterScreen=�6;   $��1361.25��6`   .��5
      � .+�5   
   �� $��30(�6    � 	Resources 5       �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� m     �� 5      " ��6   .�5      ��  � ��
	 ��  �64   �� 5       � ��$	 8q�69   5      �� 5      " ��6   .�5      ��  � ��	 5      �� 5      "
 ��6.   .R�5   "   �� $��Border��6)   $��1,1,1,0q�67   
�������$ 	10,10,0,0��6i   $	��2,0q�6�   ._�5   &   �� $ ContentSite��67   $��Center=�5   )   $��Center=�5   )   $��Header��5   )   $
��10,2q�5   )   5   #    5   "   P� 5   &    �@��
IsSelected . . �5   *   �� $ Border��61    � ��
	 ��  �6[   5   '   P� 5    &    �@��
IsSelected .  . �5!   *   �� $ Border��61    � ��
	 �����6[   5"   '   5$      5&      5'      5(      .@�5)      �� ��5*      �� 5+       �� Orientation$ 
Horizontal=�6!   .+�5,      �� $��
BÁN HÀNG��6$   5-      5/      �� 50      ��51      �� 52      $ 
Horizontal=�6!   .+�53      �� $��TƯ VẤN BÁN HÀNG��6$   54      .��56      �  � RowDefinitions 57      �� 58      $��30 �6(   �� 59      $��40 �6(   �� 5:      $��* �6(   .+�5=      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6W   $��0��6r   .+�5>      �� -   5         ��Name$ searchTextBox1��5>   "   $��Mã Code��6�   $	��200��6�   $��30��6�   $��20(�6�   $��Center=�6�   �� 5?      -   5         ��Name$ searchButton1��5?   !   
�������$��2q�6g   
���  ��$
��Bold"�6�   $��SEARCH��6�   $��20(�6�   5@      �� 5B      $ 
Horizontal=�6!   $��1��6:   $��0,5,0,0q�6G   .+�5C      �� $��Filter��6$   
���  ��$
��Bold"�6C   $��25(�6U   $��	20,5,20,0q�6c   �� 5D      $��Màu: ��6$   $��25(�61   $��5,5,0,0q�6?   �� 5E      -   5         ��Name$ 
cmbColors1��5E   #   $	��120��67   ��5F      �� 5G   "   .R�5H   &   �� $	��100��6K   $��20(�6W   ��60   �� *	ColorName+6W   5I   #   5K      �� 5M      $��Thương Hiệu: ��6$   $��25(�69   $��20,5,0,0q�6G   �� 5N      -   5        $ 
cmbBrands1��5N   #   $	��120��67   $��Center=�6C   $��Center=�6^   ��5O      �� 5P   "   .R�5Q   &   �� $	��100��6K   $��Center=�6W   $��20(�6r   ��60   �� *	BrandName+6r   5R   #   5T      �� 5V      $��Giá: ��6$   $��25(�61   $��20,5,0,0q�6?   �� 5W      -   5        $ minimumPrice1��5W   "   $��tối thiểu��69   $��80��6J   $��15(�6U   $��Center=�6c   $��Center=�6�   �� 5X      $	�� - ��6$   $��25(�6/   �� 5Y      -   5        $ maximumPrice1��5Y   "   $��	tối đa��69   $��80��6G   $��15(�6R   $��Center=�6`   $��Center=�6�   �� 5[      $��Loại: ��6$   $��25(�62   $��20,5,0,0q�6@   �� 5\      -   5        $ 	cmbTypes1��5\   #   $	��120��66   $��Center=�6B   $��Center=�6]   ��5]      �� 5^   "   .R�5_   &   �� $	��100��6J   $��Center=�6V   $��20(�6q   ��60   �� *
TypeName+6q   5`   #   5b      �� 5d      -   5        $ filterButton1��5d   !   $��Lọc��6T   $
��Bold"�6b   
���  ��$��	100,0,0,0q�6�   �� 5e      -	   5        $ refreshButton1��5e   !   $��
Làm mới��6V   $
��Bold"�6h   
���  ��$��10,0,0,0q�6�   5f      � 5h      $��2��6   $��0,5,0,0q�6(   .+�5i      �� -
   5         ��Name$ goodsListView1��5i   #   $��Disabled=�6n   ��5j      �� 5k   "   .R�5l   &   �  � Orientation$ 
Horizontal=�60   5m   #   ��5o      �� 5p   "   .R�5q   &   �� 
����ح�$��5q�6E   ._�5r   *   �� $	��150��65   $	��150��6A   $��20q�6N   .+�5s   .   �� $��5q�64   $��80��6Z   $��80��6e   $ HighQuality=�6q   ��6?   �� *	Picture+6q   �� 5t   .   $��30��6L   ��65   Z� ._�5u   2   �� $��14(�6<   $
��Wrap=�6J   $��Center=�6y   $��Center=�6�   
���  ��$
��Bold"�6�   ��6^   �� *	GoodsName+6�   5v   /   �� 5w   .   $��30��6L   ��65   Z� ._�5x   2   �� $��14(�6<   $
��Wrap=�6J   $��Center=�6�   $��Center=�6�   
���  ��$
��Bold"�6�   ��6^   �� *Price+   priceConverter �� 	Converter# [  6�   5y   /   5z   +   5{   '   5|   #   5~      5      5�      5�      �� 5�      ��5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��CẬP NHẬT��6$   5�      .��5�      �  5�      �� 5�      $��40 �6(   �� 5�      $��40 �6(   �� 5�      $��* �6(   .+�5�      � $��0��6    � ColumnDefinitions 5�      �� 5�      $��3* �6/   �� 5�      $��7* �6/   .+�5�      �� -   5        $ addNew��5�   !   $��40��6F   
��� � �
�������$
��Left=�6x   $	��180��6�   $��Center=�6�   $��Center=�6�   $��Thêm Mới��6�   $��0��6�   �� 5�      $��1��6%   $ 
Horizontal=�65   $
��Left=�6N   $��	100,0,0,0q�6i   $��Center=�6}   .+�5�      �� -   5        $ searchTextBox2��5�   &   $��Mã Code��6�   $	��200��6�   $��30��6�   $��20(�6�   $��Center=�6�   �� 5�      -   5        $ searchButton2��5�   %   
�������$��2q�6k   
���  ��$
��Bold"�6�   $��SEARCH��6�   $��20(�6�   5�      5�      �� 5�      $ 
Horizontal=�6!   $��1��6:   $��0,5,0,0q�6G   .+�5�      �� $��Filter��6$   
���  ��$
��Bold"�6C   $��25(�6U   $��	20,5,20,0q�6c   �� 5�      $��Màu: ��6$   $��25(�61   $��5,5,0,0q�6?   �� 5�      -   5        $ 
cmbColors2��5�   #   $	��120��67   ��5�      �� 5�   "   .R�5�   &   �� $	��100��6K   $��20(�6W   ��60   �� *	ColorName+6W   5�   #   5�      �� 5�      $��Thương Hiệu: ��6$   $��25(�69   $��20,5,0,0q�6G   �� 5�      -   5        $ 
cmbBrands2��5�   #   $	��120��67   $��Center=�6C   $��Center=�6^   ��5�      �� 5�   "   .R�5�   &   �� $	��100��6K   $��Center=�6W   $��20(�6r   ��60   �� *	BrandName+6r   5�   #   5�      �� 5�      $��Giá: ��6$   $��25(�61   $��20,5,0,0q�6?   �� 5�      -   5        $ minimumPrice2��5�   "   $��tối thiểu��6�   $��80��6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5�      $	�� - ��6$   $��25(�6/   �� 5�      -   5        $ maximumPrice2��5�   "   $��	tối đa��6   $��80��6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5�      $��Loại: ��6$   $��25(�62   $��20,5,0,0q�6@   �� 5�      -   5        $ 	cmbTypes2��5�   #   $	��120��66   $��Center=�6B   $��Center=�6]   ��5�      �� 5�   "   .R�5�   &   �� $	��100��6J   $��Center=�6V   $��20(�6q   ��60   �� *
TypeName+6q   5�   #   5�      �� 5�      -   5        $ filterButton2��5�   !   $��Lọc��6T   $
��Bold"�6b   
���  ��$��	100,0,0,0q�6�   �� 5�      -   5        $ refreshButton2��5�   !   $��
Làm mới��6V   $
��Bold"�6h   
���  ��$��10,0,0,0q�6�   5�      � 5�      $��2��6   .+�5�      �� -   5        $ goodsListView2��5�   #    �� View 5�      �� 5�   "   .P�5�   &   ��  �� Width$	 200��65    �� DisplayMemberBinding 6A   �� *	GoodsCode+��5�   *   �� 5�   .   
 � Tag$ 	GoodsCode��6C   $��Mã sản phẩm��6S   5�   '   �� 5�   &   $	 200��65    6A   �� *	GoodsName+��5�   *   �� 5�   .   $ 	GoodsName��6C   $��Tên sản phẩm��6S   5�   '   �� 5�   &   $ 90��65    6@   �� *Color+��5�   *   �� 5�   .   $ Color��6C   $
��Màu��6O   5�   '   �� 5�   &   $	 210��65    6A   �� *Brand+��5�   *   �� 5�   .   $ Brand��6C   $��Thương hiệu��6O   5�   '   �� 5�   &   $	 150��65    6A   �� *Size+��5�   *   �� 5�   .   $
 Size��6C   $��Kích thước��6N   5�   '   �� 5�   &   $ 85��65    6@   �� *Type+��5�   *   �� 5�   .   $
 Type��6C   $��Loại��6N   5�   '   �� 5�   &   $	 120��65    6A   �� *Price+��5�   *   �� 5�   .   $ Price��6C   $��Giá (VNĐ)��6O   5�   '   �� 5�   &   $	 280��65   ��5�   *   �� 5�   .   $ Picture��6C   $��Hình Ảnh��6Q    �� CellTemplate 5�   *   �� 5�   .   .R�5�   2   �� $��50,0,0,0q�68   $	��150��6e   $	��150��6r   ��6J   �� *	Picture+6r   5�   /   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      