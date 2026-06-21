# Feedback Event Detail Spec

## 繁體中文

- Feedback Event Detail Spec 只定義 start、drift、boost、near miss、score tick、collision、retry 的 HUD/SFX/haptics/camera event。
- haptics 僅用於 collision 與高價值 near miss/boost，不可在每次普通得分時震動。
- Acceptance: feedback event 不遮擋車體、障礙、HUD，也不破壞 reduced motion 設定。

## English

- Feedback Event Detail Spec defines only HUD/SFX/haptics/camera events for start, drift, boost, near miss, score tick, collision, and retry.
- Haptics are reserved for collision and high-value near miss/boost, not every ordinary score tick.
- Acceptance: feedback events do not obscure the vehicle, hazards, or HUD, and do not break reduced-motion settings.
