   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       BSASGUI.UserDashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	   
�������  � Title$  UserDashboard��5	   	   $	��500��6   $	��800��6,   .��5
      �  � RowDefinitions 5      �� 5      $��70 �6    �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��500 �6#   .+�5      �� $��0��6   $��0��6'    �� Orientation$ 
Horizontal=�67   .+�5      �� -   5         ��Name$ 
txtSearch1��5      $��26��6.   $	��100��6:   $
��10,5q�6F   �� 5      -   5         ��Name$ 
btnSearch1��5      $��Search��6-   $��26��6>   $	��100��6K   $
��5,10q�6W   6e   5       �� 5"      $��0��6   $��1��6'   $ 
Horizontal=�67   .+�5$      �� -   5        $ btnProduct1��5$      $��Products��6.   $��26��6A   $	��100��6N   $��85,10q�6Z   6i   �� 5%      -   5        $ btnAppointment��5%      $��Appointments��61   $��26��6H   $	��100��6U   $��-50,10q�6a   6q   �� 5&      -   5        $ 
btnLogout1��5&      $��Logout��6-   $��26��6>   $	��100��6K   $��90,22q�6W   6f   5'      ]� 5(      $��1��6   $��0��6%   $��2��65   $��
5,5,5,-226q�6I   .+�5)      �� $��3q�6   
���   � �� CornerRadius$ 10��6A    �� Padding$ 4q�6S   $��
0,0,0,-112q�6`   $	��752��6t    J� Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+      	   Color$
	 Gray��6+   
   Opacity$
 .5Q�5,   '      ShadowDepth$ 4Q�5-   '   ._�5/       � -   5        $��frmMain��5/        � NavigationUIVisibility$ Hidden=�6+   $��	0,3,-32,3q�6K   $	��770��6^   50      52      5:      5;      