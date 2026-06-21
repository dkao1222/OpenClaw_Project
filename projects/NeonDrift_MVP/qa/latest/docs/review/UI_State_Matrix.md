# UI State Matrix

## 繁體中文

- UI State Matrix 只定義 MainMenu、Running、Paused、Failure、RetryTransition 五個 UI state 與 allowed transitions。
- 每個 state 必須列出 visible elements、enabled controls、disabled controls、feedback events 與 exit trigger。
- Acceptance: GameSessionController 與 NeonDriftHud 可用本矩陣同步 UI 顯示，不需要推測狀態切換。

## English

- UI State Matrix defines only MainMenu, Running, Paused, Failure, and RetryTransition states plus allowed transitions.
- Each state must list visible elements, enabled controls, disabled controls, feedback events, and exit trigger.
- Acceptance: GameSessionController and NeonDriftHud can synchronize UI display from this matrix without guessing transitions.
