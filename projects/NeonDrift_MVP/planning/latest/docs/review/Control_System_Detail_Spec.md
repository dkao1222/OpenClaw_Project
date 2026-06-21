# Control System Detail Spec

## 繁體中文

- Control System Detail Spec 只定義 touch input、drift intent、steering output、input smoothing 與失敗前控制回饋。
- 輸入不得依賴不可見按鈕；left/right zones 需要在 onboarding 或首次 run 以視覺提示說明。
- Acceptance: 在 60fps 目標下，玩家操作與車體反應延遲需維持在可感知穩定範圍，且 readback QA 可重現。

## English

- Control System Detail Spec defines only touch input, drift intent, steering output, input smoothing, and pre-failure control feedback.
- Input cannot depend on invisible buttons; left/right zones need visual teaching in onboarding or the first run.
- Acceptance: at a 60fps target, player input and vehicle response latency remain predictably stable and reproducible by QA.
