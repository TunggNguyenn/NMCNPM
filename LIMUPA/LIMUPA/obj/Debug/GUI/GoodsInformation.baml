   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	   !    LIMUPA.GUI.GoodsInformation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	     � Title$  Information��5   	   $
��Bold"�6   $	��700��6/   $	��550��6<    � WindowStartupLocation$ CenterScreen=�6H    � 
ResizeMode$ NoResize=�6m   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��Mã sản phẩm:   ��6   $��10,0,0,0q�6/   $
��Bold"�6A   
���  ��$��30(�6d   �� 5      $��Italic$�63   
����  �$��26(�6X   ��6   �� *	GoodsCode+6X   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $��Tên sản phẩm:   ��6   $��10,0,0,0q�60   $
��Bold"�6B   
���  ��$��30(�6e   �� 5      $��Italic$�63   
����  �$��26(�6X   ��6   �� *	GoodsName+6X   5      �� 5    
   $��2��6   $ 
Horizontal=�6"   .+�5!      �� $��Màu:   ��6   $��10,0,0,0q�6'   $
��Bold"�69   
���  ��$��30(�6\   �� 5"      $��Italic$�6Z   
����  �$��26(�6   ��6   �� *Color+   colorConverter �� 	Converter# [  6   5#      �� 5%   
   $��3��6   $ 
Horizontal=�6"   .+�5&      �� $��Thương hiệu:   ��6   $��10,0,0,0q�6/   $
��Bold"�6A   
���  ��$��30(�6d   �� 5'      $��Italic$�6Z   
����  �$��26(�6   ��6   �� *Brand+  brandConverter# [ 6   5(      �� 5*   
   $��4��6   $ 
Horizontal=�6"   .+�5+      �� $��Kích thước:   ��6   $��10,0,0,0q�6.   $
��Bold"�6@   
���  ��$��30(�6c   �� 5,      $��Italic$�6X   
����  �$��26(�6}   ��6   �� *Size+  sizeConverter# [ 6}   5-      �� 5/   
   $��5��6   $ 
Horizontal=�6"   .+�50      �� $��
Loại:   ��6   $��10,0,0,0q�6(   $
��Bold"�6:   
���  ��$��30(�6]   �� 51      $��Italic$�6X   
����  �$��26(�6}   ��6   �� *Type+  typeConverter# [ 6}   52      �� 54   
   $��6��6   $ 
Horizontal=�6"   .+�55      �� $��Giá:   ��6   $��10,0,0,0q�6'   $
��Bold"�69   
���  ��$��30(�6\   �� 56      $��Italic$�6Z   
����  �$��26(�6   ��6   �� *Price+  priceConverter# [ 6   57      � 59   
   $��7��6    � ColumnDefinitions 5:      �� 5;      $��3* �6#   �� 5<      $��7* �6#   .+�5?      �� $��10,0,0,0q�6   $��Center=�6*   $��0��6E   $��Hình ảnh:   ��6U   $
��Bold"�6i   
���  ��$��30(�6�   �� 5@      $��1��6    �� BitmapScalingMode$ HighQuality=�6?   $	��300��6m   $	��300��6z   ��6$   �� *	Picture+6z   5A      �� 5C   
   -   5         ��Name$ OkButton��5C      
�������$��30��6M   $��80��6Y   
��� � �$��OK��6w   $��0,0,50,0q�6�   $��8��6�   $��Center=�6�   $��Right=�6�   5D      5E      