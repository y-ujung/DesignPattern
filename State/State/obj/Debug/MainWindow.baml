   M S B A M L   `   `   `  ����@  <State, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StateState  5   	       State.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:State     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��334��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ attack��5
      $
��Left=�6C   $��	40,80,0,0q�6^   $	��Top=�6q   $��75��6�   ��6!   �� *UnitAction[0]+��6�   �� *AttackCommand+�� 5   
   -   5        $
 move��5      $
��Left=�6A   $��
40,125,0,0q�6\   $	��Top=�6p   $��75��6�   ��6   �� *UnitAction[1]+��6�   �� *MoveCommand+�� 5   
   -   5         ��Name$ label��5      $
��Left=�6<   $��	40,20,0,0q�6W   $	��Top=�6j   $	��105��6�   $��50��6�   ��6   �� *
CurState+6�   �� 5   
   -   5        $ button��5      $
��Left=�6B   $��
186,80,0,0q�6]   $	��Top=�6q   $��75��6�    J� RenderTransformOrigin$ 
0.467,0.75&�6�   $��0��6�   ��6!   �� *UnitState[0]+��6�   �� *StateChangeCommand+6�   �� 5   
   -   5        $ button_Copy��5      $
��Left=�6G   $��186,105,0,0q�6b   $	��Top=�6w   $��75��6�   $ 
0.467,0.75&�6�   $��1��6�   ��6&   �� *UnitState[1]+��6�   �� *StateChangeCommand+6�   �� 5   
   -   5        $ button_Copy1��5      $
��Left=�6H   $��186,130,0,0q�6c   $	��Top=�6x   $��75��6�   $ 
0.467,0.75&�6�   $��2��6�   ��6'   �� *UnitState[2]+��6�   �� *StateChangeCommand+6�   �� 5   
   -   5        $ button_Copy2��5      $
��Left=�6H   $��186,155,0,0q�6c   $	��Top=�6x   $��75��6�   $ 
0.467,0.75&�6�   $��3��6�   ��6'   �� *UnitState[3]+��6�   �� *StateChangeCommand+6�   5      5      