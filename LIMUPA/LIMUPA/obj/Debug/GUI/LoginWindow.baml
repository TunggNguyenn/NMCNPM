   M S B A M L   `   `   `  ����A  =LIMUPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LIMUPALIMUPA  5   	       LIMUPA.GUI.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:LIMUPA     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	    � 
ResizeMode$ NoResize=�6   $	��500��5
   
   $	��350��6    � WindowStartupLocation$ CenterScreen=�6#    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�6    � Icon$ /Images/shoppingLogo.png��5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Orange��6#    � Offset$ 0Q�62   � 5      $ Purple��6#   $ 1Q�62   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H   	 �� RadiusX$	 10��6V   
 �� RadiusY$
 10��6c   
���������5      �� 5       �� Color$ 
DarkOrange��6"   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   
����  �$��5q�6k   $
��Bold"�6v   $��20(�6�   �� 5      -   5        $��
stateLabel��5      $�� ��6&   $
��Left=�61   $	��Top=�6L   
���  ��$��10,40q�6u   $
��Bold"�6�   $��10(�6�   �� 5       $��Center=�6   $��15q�64   .+�5!      �� -   5         ��Name$ usernameTextBox��5!      $
��0,10q�63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ USERNAME��6A    %  !MaterialDesignFloatingHintTextBox#��[  6k   $��Champagne & Limousines)�6�   $��18(�6�   G� 5"      -   5         G�Name$ passwordBox��5"      $
��0,10q�63    G� PasswordChar$ .��6A   $ PASSWORD��6R    ) %MaterialDesignFloatingHintPasswordBox#��[ 6|   $��Champagne & Limousines)�6�   $��18(�6�   5#      5$      �� 5%   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   .+�5&      �� -   5         ��Name$ loginButton��5&      $	��100��6D   $��	0,0,10,65q�6P   $��LOGIN��6c   �� 5'      -   5        $ cancelButton��5'      $	��100��6F   $��	10,0,0,65q�6R   $��CANCEL��6f   5(      �� 5)   
   $��FORGOTTEN ACCOUNT?��6   $��Center=�6.   $��Bottom=�6K   $��30q�6f   
������� � Cursor$
 Hand��6�   �� 5*   
   $��/Images/home.png��6   $	��100��6*   $	��100��66   $	��Top=�6C   $��30q�6[   5+      5,      