   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LIMUPA.GUI
LIMUPA.GUI  5   	       LIMUPA.GUI.SettingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LIMUPA.GUI     5   	     � Title$  Setting��5   
    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�6-    � 
ResizeMode$ NoResize=�5	   	   $	��350��6   $	��920��6,   $��Segoe UI Emoji)�5
   	   $��1q�5   	   
���� ��.��5      � .+�5   
   �� $��40��6   $	��Top=�6    ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      .@�5      �� .��5      �� .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/info.png��6    	 �� BitmapScalingMode$	 HighQuality=�6:   �� 5      $��SETTING��6$   $��20(�63   $��5,0,0,0q�6A   $
��Bold"�6R   5      5      5      �� 5      $��Right=�6   $��55��68   .��5      �� -   5        
 ��Name$
 
exitButton��5      
����  �$��34��6X   .��5      �� $��/Images/x-button.png��6   $	 HighQuality=�6:   5       5!      5"      � 5$   
   $	��Top=�6   $��0,40,0,0q�6'    � RowDefinitions 5%      �� 5&      $��50 �6    �� 5'      $	��200 �6    �� 5(      $��50 �6    .+�5+      �� $��0��6   $ 
Horizontal=�6&   $��Center=�6?   $��Center=�6\   .+�5,      �� $��0��6   $ 
Horizontal=�6*   .+�5-      �� $��
NHÂN SỰ��6    $��20(�6/   
���  ��$
��Bold"�6N   5.      5/      � 51      $��1��6   .+�52      �� -   5         ��Name$ staffListView��52       � ContextMenu 53      �� 54       �� 	StaysOpen . 
������� J� BitmapEffect 55      �� 56   "   .@�58      m� -   5         m�Name$ editMenuItem��58   '   $
��EDIT��6=   m� 59      -   5        $ removeMenuItem��59   '   $��REMOVE��6?   5:       �� View 5<      �� 5=      .P�5>      ��  �� Width$	 200��6-    �� DisplayMemberBinding 69   �� *
NameUser+��5?   "   �� 5@   &   
 � Tag$ NameUser��6;   $
��Bold"�6J   
���  ��$��Center=�6m   $��	NAME USER��6�   5B      �� 5C      $	 200��6-    69   �� *ID+   permissionnameConverter �� 	Converter# [  ��5D   "   �� 5E   &   $ 
Permission��6;   $
��Bold"�6M   
���  ��$��Center=�6p   $��
PERMISSION��6�   5G      �� 5H      $	 500��6-    69   �� *ID+ " permissiondescriptionConverter# [ ��5I   "   �� 5J   &   $ Description��6;   $
��Bold"�6M   
���  ��$��Center=�6p   $��DESCRIPTION��6�   5L      5M      5O      5P      �� 5R      $��2��6   $ 
Horizontal=�6&   $��Right=�6@   .+�5S      �� -   5        $
 okButton��5S      
�������$��	0,0,100,0q�6U   $��2q�6h   $��40��6|   $
��Bold"�6�   $	��120��6�   $��OK��6�   $��5��6�   $��Right=�6�   5T      5V      5W      5X      