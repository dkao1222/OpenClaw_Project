# Scoring Failure Retry Detail Spec

## 繁體中文

- Scoring Failure Retry Detail Spec 只定義分數事件、combo 中斷、失敗原因、result screen 與 retry flow。
- failure reason 必須對應 collision、off-line 或 hazard impact，不能只有 Game Over。
- Acceptance: QA 能以單局測試 survival score、near miss、combo、collision failure 與 retry transition。

## English

- Scoring Failure Retry Detail Spec defines only score events, combo break, failure reason, result screen, and retry flow.
- Failure reason must map to collision, off-line, or hazard impact instead of only showing Game Over.
- Acceptance: QA can test survival score, near miss, combo, collision failure, and retry transition in one run.
