   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	       LIMUPA.GUI.ViewBillWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	     � Title$  ViewBillWindow��5   	    � WindowStyle$
 None=�6     � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�5	   	   $	��500��6   $	��900��6,   $��Segoe UI Emoji)�5
   	   $��1q�5   	   
���� ��.��5      � .+�5   
   �� $��40��6   $	��Top=�6    ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      .@�5      �� .��5      �� .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/info.png��6    	 �� BitmapScalingMode$	 HighQuality=�6:   �� 5      $
��BILL��6$   $��20(�60   $��5,0,0,0q�6>   $
��Bold"�6O   5      5      5      �� 5      $��Right=�6   $��55��68   .��5      �� -   5        
 ��Name$
 
exitButton��5      
����  �$��34��6X   .��5      �� $��/Images/x-button.png��6   $	 HighQuality=�6:   5       5!      5"      � 5$   
   $	��Top=�6   $��0,40,0,0q�6'    � RowDefinitions 5%      �� 5&      $��40 �6    �� 5'      $��* �6    .+�5*      � $��0��6   .+�5+      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5,      �� -   5         ��Name$ searchTextBox��5,       �� TextAlignment$ Center=�65   $�� ��6L   $	��200��6T   $��20(�6`   $��Center=�6n   �� 5-      -   5        $
 searchButton��5-      
�������$��2q�6a   
���  ��$
��Bold"�6�   $��20(�6�   .��5.      �� $��/Images/search.png��6    5/      50      51      � 53      $��1��6   $��0,5,0,0q�6    .+�54      �� -   5         ��Name$ billListView��54       � ContextMenu 55      �� 56       �� 	StaysOpen . 
������� J� BitmapEffect 57      �� 58   "   .@�5:      m� -   5         m�Name$ editMenuItem��5:   '   $
��EDIT��6=   m� 5;      -   5        $ removeMenuItem��5;   '   $��REMOVE��6?   5<       �� View 5>      �� 5?      .P�5@      ��  �� Width$	 100��6-    �� DisplayMemberBinding 69   �� *
BillCode+��5A   "   �� 5B   &   
 � Tag$ BillCode��6;   $
��Bold"�6J   
���  ��$��Center=�6m   $��ID��6�   5D      �� 5E      $	 200��6-    69   �� *CustomerName+��5F   "   �� 5G   &   $ CustomerName��6;   $
��Bold"�6N   
���  ��$��Center=�6q   $��CUSTOMER NAME��6�   5I      �� 5J      $	 200��6-    69   �� *
ID_Staff+   userConverter �� 	Converter# [  ��5K   "   �� 5L   &   $ 	StaffName��6;   $
��Bold"�6K   
���  ��$��Center=�6n   $��
STAFF NAME��6�   5N      �� 5O      $	 180��6-    69   �� *
DateTime+��5P   "   �� 5Q   &   $ DateTime��6;   $
��Bold"�6J   
���  ��$��Center=�6m   $��DATETIME��6�   5S      �� 5T      $	 180��6-    69   �� *Total+��5U   "   �� 5V   &   $ Total��6;   $
��Bold"�6G   
���  ��$��Center=�6j   $��TOTAL (VNĐ)��6�   5X      5Y      5[      5\      5]      5^      5_      