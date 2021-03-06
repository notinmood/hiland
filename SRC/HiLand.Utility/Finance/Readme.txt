﻿
 /*
     1.等额本金还款方式
        等额本金还款方式比较简单。顾名思义，这种方式下，每次还款的本金还款数是一样的。因此：
        当月本金还款=总贷款数÷还款次数
        当月利息=上月剩余本金×月利率
        =总贷款数×（1－（还款月数-1）÷还款次数）×月利率
        当月月还款额=当月本金还款＋当月利息
        =总贷款数×（1÷还款次数＋（1－（还款月数-1）÷还款次数）×月利率）
        总利息＝所有利息之和
        =总贷款数×月利率×（还款次数－（１＋２＋３＋。。。＋还款次数－1）÷还款次数）
        其中1+2+3+…+还款次数－１是一个等差数列，其和为（1＋还款次数－１）×（还款次数－１）／2＝还款次数×（还款次数－１）／２
        所以，经整理后可以得出：
        总利息=总贷款数×月利率×（还款次数＋1）÷2
        由于等额本金还款每个月的本金还款额是固定的，而每月的利息是递减的，因此，等额本金还款每个月的还款额是不一样的。开始还得多，而后逐月递减。 
     */

 /*
     2.等额本息还款方式
        等额本息还款方式的公式推导比较复杂，不过也不必担心，只要具备高中数列知识就可以推导出来了。
        等额本金还款，顾名思义就是每个月的还款额是固定的。由于还款利息是逐月减少的，因此反过来说，每月还款中的本金还款额是逐月增加的。
        首先，我们先进行一番设定：
        设：总贷款额＝Ａ
        还款次数＝Ｂ
        还款月利率＝Ｃ
        月还款额＝Ｘ
        当月本金还款＝Ｙｎ（ｎ＝还款月数）
        先说第一个月，当月本金为全部贷款额＝Ａ，因此：
        第一个月的利息＝Ａ×Ｃ
        第一个月的本金还款额
        Ｙ１＝Ｘ－第一个月的利息
        ＝Ｘ－Ａ×Ｃ
        第一个月剩余本金＝总贷款额－第一个月本金还款额
        ＝Ａ－（Ｘ－Ａ×Ｃ）
        ＝Ａ×（１＋Ｃ）－Ｘ
        再说第二个月，当月利息还款额＝上月剩余本金×月利率
        第二个月的利息＝（Ａ×（１＋Ｃ）－Ｘ）×Ｃ
        第二个月的本金还款额
        Ｙ２＝Ｘ－第二个月的利息
        ＝Ｘ－（Ａ×（１＋Ｃ）－Ｘ）×Ｃ
        第二个月剩余本金＝第一个月剩余本金－第二个月本金还款额
        ＝Ａ×（１＋Ｃ）－Ｘ－（Ｘ－（Ａ×（１＋Ｃ）－Ｘ）×Ｃ）
        ＝Ａ×（１＋Ｃ）－Ｘ－Ｘ＋（Ａ×（１＋Ｃ）－Ｘ）×Ｃ
        ＝Ａ×（１＋Ｃ）×（１＋Ｃ）－［Ｘ＋（１＋Ｃ）×Ｘ］
        ＝Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］
        (1+C)^2表示(1+C)的2次方
        第三个月，
        第三个月的利息＝第二个月剩余本金×月利率
        第三个月的利息＝（Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］）×Ｃ
        第三个月的本金还款额
        Ｙ３＝Ｘ－第三个月的利息
        ＝Ｘ－（Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］）×Ｃ
        第三个月剩余本金＝第二个月剩余本金－第三个月的本金还款额
        ＝Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］
        －（Ｘ－（Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］）×Ｃ）
        ＝Ａ×（１＋Ｃ）^２－［Ｘ＋（１＋Ｃ）×Ｘ］
        －（Ｘ－（Ａ×（１＋Ｃ）^２×Ｃ＋［Ｘ＋（１＋Ｃ）×Ｘ］）×Ｃ）
        ＝Ａ×（１＋Ｃ）^２×（１＋Ｃ）
        －（Ｘ＋［Ｘ＋（１＋Ｃ）×Ｘ］×（１＋Ｃ））
        ＝Ａ×（１＋Ｃ）^３　－［Ｘ＋（１＋Ｃ）×Ｘ＋（１＋Ｃ）^２×Ｘ］
        上式可以分成两个部分
        第一部分：Ａ×（１＋Ｃ）^３。
        第二部分：［Ｘ＋（１＋Ｃ）×Ｘ＋（１＋Ｃ）^２×Ｘ］
        ＝Ｘ×［１＋（１＋Ｃ）＋（１＋Ｃ）^２］
        通过对前三个月的剩余本金公式进行总结，我们可以看到其中的规律：
        剩余本金中的第一部分＝总贷款额×（１＋月利率）的ｎ次方，（其中ｎ＝还款月数）
        剩余本金中的第二部分是一个等比数列，以（１＋月利率）为比例系数，月还款额为常数系数，项数为还款月数ｎ。
        推广到任意月份：
        第ｎ月的剩余本金＝Ａ×（１＋Ｃ）^ｎ　－Ｘ×Ｓｎ（Ｓｎ为（１＋Ｃ）的等比数列的前ｎ项和）
        根据等比数列的前ｎ项和公式：
        １＋Ｚ＋Ｚ２＋Ｚ３＋．．．＋Ｚｎ－１＝（１－Ｚ^ｎ）／（１－Ｚ）
        可以得出
        Ｘ×Ｓｎ＝Ｘ×（１－（１＋Ｃ）^ｎ）／（１－（１＋Ｃ））
        ＝Ｘ×（（１＋Ｃ）^ｎ－１）／Ｃ
        所以，第ｎ月的剩余本金＝Ａ×（１＋Ｃ）^ｎ－Ｘ×（（１＋Ｃ）^ｎ－１）／Ｃ
        由于最后一个月本金将全部还完，所以当ｎ等于还款次数时，剩余本金为零。
        设ｎ＝Ｂ（还款次数）
        剩余本金＝Ａ×（１＋Ｃ）^Ｂ－Ｘ×（（１＋Ｃ）^Ｂ－１）／Ｃ＝０
        从而得出
        月还款额
        Ｘ＝Ａ×Ｃ×（１＋Ｃ）^Ｂ÷（（１＋Ｃ）^Ｂ－１）
        ＝　　总贷款额×月利率×（１＋月利率）^还款次数÷[（?000保吕剩还款次数－１]
        将Ｘ值带回到第ｎ月的剩余本金公式中
        第ｎ月的剩余本金＝Ａ×（１＋Ｃ）^ｎ－［Ａ×Ｃ×（１＋Ｃ）^Ｂ／（（１＋Ｃ）^Ｂ－１）］×（（１＋Ｃ）^ｎ－１）／Ｃ
        ＝Ａ×［（１＋Ｃ）^ｎ－（１＋Ｃ）^Ｂ×（（１＋Ｃ）^ｎ－１）／（（１＋Ｃ）^Ｂ－１）］
        ＝Ａ×［（１＋Ｃ）^Ｂ－（１＋Ｃ）^ｎ］／（（１＋Ｃ）^Ｂ－１）
        第ｎ月的利息＝第ｎ－１月的剩余本金×月利率
        ＝Ａ×Ｃ×［（１＋Ｃ）^Ｂ－（１＋Ｃ）^(ｎ－１)］／（（１＋Ｃ）^Ｂ－１）
        第ｎ月的本金还款额＝Ｘ－第ｎ月的利息
        ＝Ａ×Ｃ×（１＋Ｃ）^Ｂ／（（１＋Ｃ）^Ｂ－１）－Ａ×Ｃ×［（１＋Ｃ）^Ｂ－（１＋Ｃ）^(ｎ－１)］／（（１＋Ｃ）^Ｂ－１）
        ＝Ａ×Ｃ×（１＋Ｃ）^(ｎ－１)／（（１＋Ｃ）^Ｂ－１）
        总还款额＝Ｘ×Ｂ
        ＝Ａ×Ｂ×Ｃ×（１＋Ｃ）^Ｂ÷（（１＋Ｃ）^Ｂ－１）
        总利息＝总还款额－总贷款额＝Ｘ×Ｂ－Ａ
        ＝Ａ×［（Ｂ×Ｃ－１）×（１＋Ｃ）^Ｂ＋１］／（（１＋Ｃ）^Ｂ－１）
        等额本息还款，每个月的还款额是固定的。由于还款初期利息较大，因此初期的本金还款额很小。相对于等额本金方式，还款的总利息要多。
     */

