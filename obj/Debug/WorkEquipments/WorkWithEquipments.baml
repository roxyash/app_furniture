   M S B A M L   `   `   `  ����I  EOrderFurniture, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OrderFurniture.WorkEquipmentsOrderFurniture.WorkEquipments  5   	   6    0OrderFurniture.WorkEquipments.WorkWithEquipments   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:OrderFurniture.WorkEquipments     5   	   -   5          � Title$  WorkWithEquipments��5   	   $��462.133��6$   $��1057.634��65    � WindowStartupLocation$ CenterScreen=�6F    � WindowStyle$
 None=�6k    � 
ResizeMode$ NoResize=�6~   .��5	      � .+�5
   
   �� $0��*/OrderFurniture;component/Resourse/Dir.jpg��6   $
��Fill=�6D   6U   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridEquipments��5   _      RowBackground
 ����    AutoGenerateColumns .     
IsReadOnly . $
��Left=�6x   $	��370��6�   $��	22,45,0,0q�6�   $	��Top=�6�   $
��1011��6�    J� RenderTransformOrigin$ 0.024,0.232&�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Маркировка��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *label+  5      $
 Наименование��6%   $ * 6;    6E   �� *Name+  5      $%
 Тип оборудования��6%   $ * 6?    6J   �� *TypeEquipment+  5      $
 Дата покупки��6%   $ * 6;    6E   �� *DateOfPurchase+ �� StringFormat$ d��  5      $"
 Характеристики��6%   $ * 6=    6G   �� *Characteristic+   RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      ��  �� Property � �� �� Value$	 100��6/   5      5      �� 5   
   -   5        
������ 
������ $
��Left=�5   E   $��
11,431,0,0q�6`   $	��Top=�6t   $��70��6�   $��22��6�   .��5      �� $1��+/OrderFurniture;component/Resourse/back.png��6   6L   5      �� 5    
   -   5         ��Name$	 Add��5       
������ 
���   �$	��Add��6K   $
��Left=�6Y   $��410,432,0,0q�6t   $	��Top=�6�   $	��200��6�   6�   �� 5!   
   -   5        $ Remove��5!      
������ 
���   �$��Remove��6N   $
��Left=�6_   $��622,432,0,0q�6z   $	��Top=�6�   $	��200��6�   6�   �� 5"   
   -   5        $ Change��5"      
������ 
���   �$��Change��6N   $
��Left=�6_   $��833,432,0,0q�6z   $	��Top=�6�   $	��200��6�   6�   �� 5#   
   -   5         ��Name$ 
TBoxSearch��5#   ?   
������ 
���   �$
��Left=�6u   $��23��6�   $��	91,11,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��883��6�   �� 5$   
   $��Search��6   $
��Left=�6!   $��	32,10,0,0q�6<   $	��Top=�6O   $��60��6g   �� 5%   
   -   5        $
��Left=�5%      $��1012,12,0,0q�6-   $	��Top=�6B   $��22��6Z   $��19��6e   
������ 
������ .��5&      �� $4��./OrderFurniture;component/Resourse/krestv2.png��6   $
��Fill=�6L   6]   5'      �� 5(   
   -	   5        $
��Left=�5(      $��
982,12,0,0q�6-   $	��Top=�6A   $��22��6Y   $��19��6d   
������ 
������ .��5)      �� $1��+/OrderFurniture;component/Resourse/sver.png��6   $
��Fill=�6I   6Z   5*      5+      5,      